#pragma checksum "..\..\..\..\..\UI\Pages\Browser\SettingsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F484C7B171031A1F207185DEF89824C1FF69E04F66D0A5EFE8C20C8DAD8F31D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AMusic.UI.Pages.Browser;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AMusic.UI.Pages.Browser {
    
    
    /// <summary>
    /// SettingsPage
    /// </summary>
    public partial class SettingsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\UI\Pages\Browser\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer svMain;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\UI\Pages\Browser\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spAccount;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\UI\Pages\Browser\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditAccount;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\UI\Pages\Browser\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuitAccount;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\..\UI\Pages\Browser\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSupport;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AMusic;component/ui/pages/browser/settingspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Pages\Browser\SettingsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.svMain = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 2:
            this.spAccount = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.btnEditAccount = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\..\UI\Pages\Browser\SettingsPage.xaml"
            this.btnEditAccount.Click += new System.Windows.RoutedEventHandler(this.btnEditAccount_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnQuitAccount = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\..\UI\Pages\Browser\SettingsPage.xaml"
            this.btnQuitAccount.Click += new System.Windows.RoutedEventHandler(this.btnQuitAccount_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSupport = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\..\UI\Pages\Browser\SettingsPage.xaml"
            this.btnSupport.Click += new System.Windows.RoutedEventHandler(this.btnSupport_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

