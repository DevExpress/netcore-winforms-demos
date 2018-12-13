using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using DevExpress.Data.Filtering;
using System.Windows.Media;
using System.Configuration;
using System.Linq.Expressions;
using System.ComponentModel;
using DevExpress.Mvvm;

namespace DevExpress.DevAV.ViewModels {
    public abstract class FilterItemBase {
        protected FilterItemBase() { }
        public virtual string Name { get; set; }
        public virtual CriteriaOperator FilterCriteria { get; set; }
    }
    public interface IFilterTreeModelPageSpecificSettings {
        string StaticFiltersTitle { get; }
        FilterInfoList StaticFilters { get; set; }
        FilterInfoList CustomFilters { get; set; }
        FilterInfoList GroupFilters { get; set; }
        ApplicationSettingsBase Settings { get; }
        IEnumerable<string> HiddenFilterProperties { get; }
        IEnumerable<string> AdditionalFilterProperties { get; }
    }

    public class FilterTreeModelPageSpecificSettings<TSettings> : IFilterTreeModelPageSpecificSettings where TSettings : ApplicationSettingsBase {
        readonly string staticFiltersTitle;
        readonly TSettings settings;
        readonly PropertyDescriptor customFiltersProperty;
        readonly PropertyDescriptor staticFiltersProperty;
        readonly PropertyDescriptor groupFiltersProperty;
        readonly IEnumerable<string> hiddenFilterProperties;
        readonly IEnumerable<string> additionalFilterProperties;

        public FilterTreeModelPageSpecificSettings(TSettings settings, string staticFiltersTitle,
            Expression<Func<TSettings, FilterInfoList>> getStaticFiltersExpression, Expression<Func<TSettings, FilterInfoList>> getCustomFiltersExpression, Expression<Func<TSettings, FilterInfoList>> getGroupFiltersExpression,
            IEnumerable<string> hiddenFilterProperties = null, IEnumerable<string> additionalFilterProperties = null) {
            this.settings = settings;
            this.staticFiltersTitle = staticFiltersTitle;
            staticFiltersProperty = GetProperty(getStaticFiltersExpression);
            customFiltersProperty = GetProperty(getCustomFiltersExpression);
            groupFiltersProperty = GetProperty(getGroupFiltersExpression);
            this.hiddenFilterProperties = hiddenFilterProperties;
            this.additionalFilterProperties = additionalFilterProperties;
        }
        FilterInfoList IFilterTreeModelPageSpecificSettings.CustomFilters {
            get { return GetFilters(customFiltersProperty); }
            set { SetFilters(customFiltersProperty, value); }
        }
        FilterInfoList IFilterTreeModelPageSpecificSettings.StaticFilters {
            get { return GetFilters(staticFiltersProperty); }
            set { SetFilters(staticFiltersProperty, value); }
        }
        FilterInfoList IFilterTreeModelPageSpecificSettings.GroupFilters {
            get { return GetFilters(groupFiltersProperty); }
            set { SetFilters(groupFiltersProperty, value); }
        }
        ApplicationSettingsBase IFilterTreeModelPageSpecificSettings.Settings { get { return settings; } }
        string IFilterTreeModelPageSpecificSettings.StaticFiltersTitle { get { return staticFiltersTitle; } }
        IEnumerable<string> IFilterTreeModelPageSpecificSettings.HiddenFilterProperties { get { return hiddenFilterProperties; } }
        IEnumerable<string> IFilterTreeModelPageSpecificSettings.AdditionalFilterProperties { get { return additionalFilterProperties; } }

        PropertyDescriptor GetProperty(Expression<Func<TSettings, FilterInfoList>> expression) {
            if(expression != null)
                return TypeDescriptor.GetProperties(settings)[GetPropertyName(expression)];
            return null;
        }
        FilterInfoList GetFilters(PropertyDescriptor property) {
            return property != null ? (FilterInfoList)property.GetValue(settings) : null;
        }
        void SetFilters(PropertyDescriptor property, FilterInfoList value) {
            if(property != null)
                property.SetValue(settings, value);
        }
        static string GetPropertyName(Expression<Func<TSettings, FilterInfoList>> expression) {
            MemberExpression memberExpression = expression.Body as MemberExpression;
            if(memberExpression == null) {
                throw new ArgumentException("expression");
            }
            return memberExpression.Member.Name;
        }
    }

    public class FilterInfo {
        public string Name { get; set; }
        public string FilterCriteria { get; set; }
        public string ImageUri { get; set; }
    }
    public class FilterInfoList : List<FilterInfo> {
        public FilterInfoList() { }
        public FilterInfoList(IEnumerable<FilterInfo> filters)
            : base(filters) {
        }
    }
    public abstract class FilterTreeViewModelBase {
        static FilterTreeViewModelBase() {
            var enums = typeof(EmployeeStatus).Assembly.GetTypes().Where(t => t.IsEnum);
            foreach(Type e in enums)
                EnumProcessingHelper.RegisterEnum(e);
        }
        protected IFilterTreeModelPageSpecificSettings settings;
        public FilterTreeViewModelBase(IFilterTreeModelPageSpecificSettings settings) {
            this.settings = settings;
        }
        public virtual void Init() {
            StaticFilters = CreateFilterItems(settings.StaticFilters);
            CustomFilters = CreateFilterItems(settings.CustomFilters);
            SelectedItem = StaticFilters.FirstOrDefault();
        }

        public virtual ObservableCollection<FilterItemBase> StaticFilters { get; protected set; }
        public virtual ObservableCollection<FilterItemBase> CustomFilters { get; protected set; }
        public virtual FilterItemBase SelectedItem { get; set; }

        protected void AddNewCustomFilter(FilterItemBase filterItem) {
            var existing = CustomFilters.FirstOrDefault(fi => fi.Name == filterItem.Name);
            if(existing != null) {
                CustomFilters.Remove(existing);
            }
            CustomFilters.Add(filterItem);
            SaveCustomFilters();
        }

        public virtual void DeleteCustomFilter(FilterItemBase filterItem) {
            CustomFilters.Remove(filterItem);
            SaveCustomFilters();
        }

        public virtual void DuplicateFilter(FilterItemBase filterItem) {
            var newItem = CreateFilterItem("Copy of " + filterItem.Name, filterItem.FilterCriteria, null);
            CustomFilters.Add(newItem);
            SaveCustomFilters();
        }
        public virtual void ResetCustomFilters() {
            if(CustomFilters.Contains(SelectedItem))
                SelectedItem = null;
            settings.CustomFilters = new FilterInfoList();
            CustomFilters.Clear();
            settings.Settings.Save();
        }

        protected ObservableCollection<FilterItemBase> CreateFilterItems(IEnumerable<FilterInfo> filters) {
            if(filters == null)
                return new ObservableCollection<FilterItemBase>();
            return new ObservableCollection<FilterItemBase>(filters.Select(x => CreateFilterItem(x.Name, CriteriaOperator.Parse(x.FilterCriteria), x.ImageUri)));
        }

        protected abstract FilterItemBase CreateFilterItem(string name, CriteriaOperator filterCriteria, string imageUri);

        protected void SaveCustomFilters() {
            settings.CustomFilters = SaveToSettings(CustomFilters);
            settings.Settings.Save();
        }
        protected FilterInfoList SaveToSettings(ObservableCollection<FilterItemBase> filters) {
            return new FilterInfoList(filters.Select(fi => new FilterInfo { Name = fi.Name, FilterCriteria = CriteriaOperator.ToString(fi.FilterCriteria) }));
        }
        protected object ViewModel { get; private set; }
        public virtual void SetViewModel(object viewModel) {
            ViewModel = viewModel;
        }
    }
}