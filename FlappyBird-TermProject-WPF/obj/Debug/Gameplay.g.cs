﻿#pragma checksum "..\..\Gameplay.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4D30AEABC7C024C87992156846F609DF7AC4BEAC2A9306F01DACFF282B1BA6AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FlappyBird_TermProject_WPF;
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


namespace FlappyBird_TermProject_WPF {
    
    
    /// <summary>
    /// Gameplay
    /// </summary>
    public partial class Gameplay : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas myCanvas;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle background;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle background2;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle flappyBird;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle boostScore;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle obstacleBot;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle obstacleTop;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle obstacleBot2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle obstacleTop2;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock scoreText;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CountdownText;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lostText;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border help;
        
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
            System.Uri resourceLocater = new System.Uri("/FlappyBird-TermProject-WPF;component/gameplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Gameplay.xaml"
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
            this.myCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 10 "..\..\Gameplay.xaml"
            this.myCanvas.KeyUp += new System.Windows.Input.KeyEventHandler(this.KeyIsUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.background = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.background2 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.flappyBird = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.boostScore = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 6:
            this.obstacleBot = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 7:
            this.obstacleTop = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 8:
            this.obstacleBot2 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 9:
            this.obstacleTop2 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 10:
            this.scoreText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.CountdownText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.lostText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.help = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

