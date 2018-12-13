using DevExpress.DevAV;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EFCore;
using System;
using System.Collections;
using System.Linq;

namespace DevExpress.DevAV.DevAVDbDataModel
{

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource
    {

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the current mode (run-time or design-time).
        /// </summary>
        public static IUnitOfWorkFactory<IDevAVDbUnitOfWork> GetUnitOfWorkFactory()
        {
            return GetUnitOfWorkFactory(ViewModelBase.IsInDesignMode);
        }

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the given mode (run-time or design-time).
        /// </summary>
        /// <param name="isInDesignTime">Used to determine which implementation of IUnitOfWorkFactory should be returned.</param>
        public static IUnitOfWorkFactory<IDevAVDbUnitOfWork> GetUnitOfWorkFactory(bool isInDesignTime)
        {
            //if (isInDesignTime)
            //    return new DesignTimeUnitOfWorkFactory<IDevAVDbUnitOfWork>(() => new DevAVDbDesignTimeUnitOfWork());
            return new DbUnitOfWorkFactory<IDevAVDbUnitOfWork>(() => new DevAVDbUnitOfWork(() => new DevAVDb(@"Data Source=devav.sqlite3")));
        }
    }
}