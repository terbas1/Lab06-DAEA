﻿using Business;
using Entity;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Semana05.ViewModel;

namespace Semana05
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListaViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = ListaViewModel.Instance;
            this.DataContext = viewModel;
        }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            BCategoria bCategoria = new BCategoria();
            dgvCategoria.ItemsSource = bCategoria.Get();
        }

        private void DgvCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (Categoria)dgvCategoria.SelectedItem;
            ManCategoria manCategoria = new ManCategoria(item);
            manCategoria.ShowDialog();
        }

        private void BtnNuevo_Click(object sender, RoutedEventArgs e)
        {
            ManCategoria manCategoria = new ManCategoria(null);
            manCategoria.ShowDialog();

        }
    }
}
