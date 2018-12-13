using System;
using System.ComponentModel;

// This class was auto-generated.
// To add or remove a member, edit your .ResX file then rerun ResGen
// with the /str option, or rebuild your VS project.

namespace DevExpress.DevAV.Common {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CommonResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CommonResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DevExpress.DevAV.Common.CommonResources", typeof(CommonResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Do you want to delete this {0}?.
        /// </summary>
        internal static string Confirmation_Delete {
            get {
                return ResourceManager.GetString("Confirmation_Delete", resourceCulture);
            }
        }


        /// <summary>
        ///   Looks up a localized string similar to Do you want to save changes?.
        /// </summary>
        internal static string Confirmation_Save {
            get {
                return ResourceManager.GetString("Confirmation_Save", resourceCulture);
            }
        }


        /// <summary>
        ///   Looks up a localized string similar to Click OK to reload the entity and lose unsaved changes. Click Cancel to continue editing data..
        /// </summary>
        internal static string Confirmation_Reset {
            get {
                return ResourceManager.GetString("Confirmation_Reset", resourceCulture);
            }
        }


        /// <summary>
        ///   Looks up a localized string similar to Confirmation.
        /// </summary>
        internal static string Confirmation_Caption {
            get {
                return ResourceManager.GetString("Confirmation_Caption", resourceCulture);
            }
        }


        /// <summary>
        ///   Looks up a localized string similar to Warning.
        /// </summary>
        internal static string Warning_Caption {
            get {
                return ResourceManager.GetString("Warning_Caption", resourceCulture);
            }
        }


        /// <summary>
        ///   Looks up a localized string similar to Some fields contain invalid data. Click OK to close the page and lose unsaved changes. Press Cancel to continue editing data..
        /// </summary>
        internal static string Warning_SomeFieldsContainInvalidData {
            get {
                return ResourceManager.GetString("Warning_SomeFieldsContainInvalidData", resourceCulture);
            }
        }


        /// <summary>
        ///   Looks up a localized string similar to Update Error.
        /// </summary>
        internal static string Exception_UpdateErrorCaption {
            get {
                return ResourceManager.GetString("Exception_UpdateErrorCaption", resourceCulture);
            }
        }


        /// <summary>
        ///   Looks up a localized string similar to Validation Error.
        /// </summary>
        internal static string Exception_ValidationErrorCaption {
            get {
                return ResourceManager.GetString("Exception_ValidationErrorCaption", resourceCulture);
            }
        }


        /// <summary>
        ///   Looks up a localized string similar to DataService Request Error.
        /// </summary>
        internal static string Exception_DataServiceRequestErrorCaption {
            get {
                return ResourceManager.GetString("Exception_DataServiceRequestErrorCaption", resourceCulture);
            }
        }


        /// <summary>
        ///   Looks up a localized string similar to  *.
        /// </summary>
        internal static string Entity_Changed {
            get {
                return ResourceManager.GetString("Entity_Changed", resourceCulture);
            }
        }


        /// <summary>
        ///   Looks up a localized string similar to  (New).
        /// </summary>
        internal static string Entity_New {
            get {
                return ResourceManager.GetString("Entity_New", resourceCulture);
            }
        }

    }
}