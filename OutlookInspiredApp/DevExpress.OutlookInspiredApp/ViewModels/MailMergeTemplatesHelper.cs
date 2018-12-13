namespace DevExpress.DevAV.ViewModels {
    using System.Collections.Generic;
    using System.IO;
    using DevExpress.Utils;

    public static class MailMergeTemplatesHelper {
        static string[] templateNames = new string[] {
            "Employee of the Month.rtf",
            "Employee Probation Notice.rtf",
            "Employee Service Excellence.rtf",
            "Employee Thank You Note.rtf",
            "Welcome to DevAV.rtf"
        };
        public static List<TemplateViewModel> GetAllTemplates() {
            List<TemplateViewModel> templates = new List<TemplateViewModel>();
            foreach(var name in templateNames) {
                Stream stream = GetTemplateStream(name);
                templates.Add(new TemplateViewModel() {
                    Name = name.Replace(".rtf", "")
                });
            }
            return templates;
        }
        public static Stream GetTemplateStream(string templateName) {
            return AssemblyHelper.GetEmbeddedResourceStream(typeof(MailMergeTemplatesHelper).Assembly, templateName, false);
        }
    }
    //
    public class TemplateViewModel {
        public string Name {
            get;
            set;
        }
        public Stream Template {
            get { return MailMergeTemplatesHelper.GetTemplateStream(Name + ".rtf"); }
        }
    }
}