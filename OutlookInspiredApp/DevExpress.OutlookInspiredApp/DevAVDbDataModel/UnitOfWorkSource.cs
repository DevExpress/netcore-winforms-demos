using System;
using System.Linq;
using DevExpress.Mvvm.DataModel;
#if DXCORE3
using DevExpress.Mvvm.DataModel.EFCore;
#else
using DevExpress.Mvvm.DataModel.EF6;
#endif

namespace DevExpress.DevAV.DevAVDbDataModel {
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {
        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IDevAVDbUnitOfWork> GetUnitOfWorkFactory() {
            Func<DevAVDb> contextFactory = () => new DevAVDb(@"Data Source=..\Data\devav.sqlite3");
            return new DbUnitOfWorkFactory<IDevAVDbUnitOfWork>(() => new DevAVDbUnitOfWork(contextFactory));
        }
    }
}