﻿using POGOProtos.Data;
using POGOProtos.Enums;
using PokemonGo_UWP.Controls;
using PokemonGo_UWP.Entities;
using PokemonGo_UWP.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Template10.Common;
using Template10.Controls;
using Template10.Mvvm;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace PokemonGo_UWP.Views
{
    public sealed partial class PokemonInventoryControl : UserControl
    {
        public PokemonInventoryControl()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty SortingModeProperty =
            DependencyProperty.Register(nameof(SortingMode), typeof(PokemonSortingModes), typeof(PokemonInventoryControl),
                new PropertyMetadata(PokemonSortingModes.Combat));

        public PokemonSortingModes SortingMode
        {
            get { return (PokemonSortingModes)GetValue(SortingModeProperty); }
            set { SetValue(SortingModeProperty, value); }
        }

        private void ShowSortingPanel_Click(object sender, RoutedEventArgs e)
        {
            SortingMenuOverlayControl sortingMenu = new SortingMenuOverlayControl();
            sortingMenu.SortingmodeSelected += ((mode) => { SortingMode = mode; });
            sortingMenu.Show();
        }
    }
}
