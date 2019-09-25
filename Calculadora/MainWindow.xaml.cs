﻿using System;
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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool suma = false;
        private bool resta = false;
        private bool multiplicacion = false;
        private bool division = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonSuma_Checked(object sender, RoutedEventArgs e)
        {
            suma = true;
            resta = false;
            multiplicacion = false;
            division = false;
        }

        private void BotonMultiplicacion_Checked(object sender, RoutedEventArgs e)
        {
            suma = false;
            resta = false;
            multiplicacion = true;
            division = false;
        }

        private void BotonResta_Checked(object sender, RoutedEventArgs e)
        {
            suma = false;
            resta = true;
            multiplicacion = false;
            division = false;
        }

        private void BotonDivision_Checked(object sender, RoutedEventArgs e)
        {
            suma = false;
            resta = false;
            multiplicacion = false;
            division = true;
        }

        private void CajaOperando2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int numero1;
            int numero2;


            if (CajaOperando1.Text.Length == 0)
            {
                numero1 = 0;
            }
            else
            {
                numero1 = Convert.ToInt32(CajaOperando1.Text);
            }

            if (CajaOperando2.Text.Length == 0)
            {
                numero2 = 0;
            }
            else
            {
                numero2 = Convert.ToInt32(CajaOperando2.Text);
            }
            

            if (suma)
            {
                CajaResultado.Text = (numero1 + numero2).ToString();
            }
            else if(resta)
            {
                CajaResultado.Text = (numero1 - numero2).ToString();
            }
            else if(multiplicacion)
            {
                CajaResultado.Text = (numero1 * numero2).ToString();
            }
            else if(division)
            {
                if (numero2 == 0)
                {
                    CajaResultado.Text = "ERROR";
                }
                CajaResultado.Text = (numero1 / numero2).ToString();
            }
            else
            {
                CajaResultado.Text = "0";
            }

            
        }
        
    }
}
