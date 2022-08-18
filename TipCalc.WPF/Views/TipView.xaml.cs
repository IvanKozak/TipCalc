﻿using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using TipCalc.Core.ViewModels;

namespace TipCalc.WPF.Views
{
    /// <summary>
    /// Interaction logic for TipView.xaml
    /// </summary>
    [MvxContentPresentation]
    [MvxViewFor(typeof(TipViewModel))]
    public partial class TipView : MvxWpfView
    {
        public TipView()
        {
            InitializeComponent();
        }
    }
}
