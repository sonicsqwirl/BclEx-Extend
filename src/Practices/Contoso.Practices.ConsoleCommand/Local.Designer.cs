﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contoso {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Local {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Local() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Contoso.Local", typeof(Local).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ambiguous command &apos;{0}&apos;. Possible values: {1}..
        /// </summary>
        internal static string AmbiguousCommand {
            get {
                return ResourceManager.GetString("AmbiguousCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ambiguous option &apos;{0}&apos;. Possible values: {1}..
        /// </summary>
        internal static string AmbiguousOption {
            get {
                return ResourceManager.GetString("AmbiguousOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No description was provided for this command..
        /// </summary>
        internal static string DefaultCommandDescription {
            get {
                return ResourceManager.GetString("DefaultCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid option value: &apos;{0} {1}&apos;.
        /// </summary>
        internal static string InvalidOptionValueError {
            get {
                return ResourceManager.GetString("InvalidOptionValueError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing option value for: &apos;{0}&apos;.
        /// </summary>
        internal static string MissingOptionValueError {
            get {
                return ResourceManager.GetString("MissingOptionValueError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [option] on &apos;{0}&apos; is invalid without a setter..
        /// </summary>
        internal static string OptionInvalidWithoutSetter {
            get {
                return ResourceManager.GetString("OptionInvalidWithoutSetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to change from type &apos;{0}&apos; to &apos;{1}&apos;..
        /// </summary>
        internal static string UnableToConvertTypeError {
            get {
                return ResourceManager.GetString("UnableToConvertTypeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown command: &apos;{0}&apos;.
        /// </summary>
        internal static string UnknownCommandError {
            get {
                return ResourceManager.GetString("UnknownCommandError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown option: &apos;{0}&apos;.
        /// </summary>
        internal static string UnknownOptionError {
            get {
                return ResourceManager.GetString("UnknownOptionError", resourceCulture);
            }
        }
    }
}
