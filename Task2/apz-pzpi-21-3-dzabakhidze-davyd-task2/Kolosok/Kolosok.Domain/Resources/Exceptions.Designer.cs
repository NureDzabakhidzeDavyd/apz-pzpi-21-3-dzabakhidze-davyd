﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kolosok.Domain.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Exceptions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Exceptions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kolosok.Domain.Resources.Exceptions", typeof(Exceptions).Assembly);
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
        ///   Looks up a localized string similar to The action with the identifier {0} was not found..
        /// </summary>
        internal static string ActionNotFoundException_Message {
            get {
                return ResourceManager.GetString("ActionNotFoundException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Brigade with the identifier {0} was not found..
        /// </summary>
        internal static string BrigadeNotFoundException_Message {
            get {
                return ResourceManager.GetString("BrigadeNotFoundException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The brigade rescuer with the identifier {0} was not found..
        /// </summary>
        internal static string BrigadeRescuerNotFoundException_Message {
            get {
                return ResourceManager.GetString("BrigadeRescuerNotFoundException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The contact with the identifier {0} was not found..
        /// </summary>
        internal static string ContactNotFoundException_Message {
            get {
                return ResourceManager.GetString("ContactNotFoundException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The diagnosis with the identifier {0} was not found..
        /// </summary>
        internal static string DiagnosisNotFoundException_Message {
            get {
                return ResourceManager.GetString("DiagnosisNotFoundException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Password.
        /// </summary>
        internal static string InvalidPasswordException_Message {
            get {
                return ResourceManager.GetString("InvalidPasswordException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The medical history with the identifier {0} was not found..
        /// </summary>
        internal static string MedicalHistoryNotFoundException_Message {
            get {
                return ResourceManager.GetString("MedicalHistoryNotFoundException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user with the email {0} was not found..
        /// </summary>
        internal static string UserNotFoundException_Message {
            get {
                return ResourceManager.GetString("UserNotFoundException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The victim with the identifier {0} was not found..
        /// </summary>
        internal static string VictimNotFoundException_Message {
            get {
                return ResourceManager.GetString("VictimNotFoundException_Message", resourceCulture);
            }
        }
    }
}
