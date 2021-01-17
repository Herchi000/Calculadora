using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
		List<double> valores = new List<double>();
		List<string> operadores = new List<string>();
		int contador = 0;

		double primerVal;
		double segundoVal;
		string operador;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Cero_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "0";
			PanelMostradorReal.Text = PanelMostradorReal.Text + "0";
		}

		private void Uno_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "1";
			PanelMostradorReal.Text = PanelMostradorReal.Text + "1";
		}

		private void Dos_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "2";
			PanelMostradorReal.Text = PanelMostradorReal.Text + "2";
		}

		private void Tres_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "3";
			PanelMostradorReal.Text = PanelMostradorReal.Text + "3";
		}

		private void Cuatro_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "4";
			PanelMostradorReal.Text = PanelMostradorReal.Text + "4";
		}

		private void Cinco_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "5";
			PanelMostradorReal.Text = PanelMostradorReal.Text + "5";
		}

		private void Seis_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "6";
			PanelMostradorReal.Text = PanelMostradorReal.Text + "6";
		}

		private void Siete_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "7";
			PanelMostradorReal.Text = PanelMostradorReal.Text + "7";
		}

		private void Ocho_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "8";
			PanelMostradorReal.Text = PanelMostradorReal.Text + "8";
		}

		private void Nueve_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "9";
			PanelMostradorReal.Text = PanelMostradorReal.Text + "9";
		}




		//OPERADORES
		private void Coma_Click(object sender, RoutedEventArgs e)
		{
			if (PanelMostrador.Text.Contains("."))
			{
				SystemSounds.Beep.Play();
			}
			else if (!(PanelMostrador.Text.Contains(".")) && PanelMostrador.Text.Length > 1)
			{
				PanelMostrador.Text = PanelMostrador.Text + ".";
				PanelMostradorReal.Text = PanelMostradorReal.Text + ".";
			}
			else
			{
				PanelMostrador.Text = "0.";
				PanelMostradorReal.Text = PanelMostradorReal.Text + "0.";
			}

			}

		private void Suma_Click(object sender, RoutedEventArgs e)
		{
			operadores.Add("+");
			valores.Add(double.Parse(PanelMostrador.Text));

			contador++;

			PanelMostradorReal.Text = PanelMostradorReal.Text + "+";
			PanelMostrador.Clear();
		}

		private void Resta_Click(object sender, RoutedEventArgs e)
		{
			operadores.Add("-");
			valores.Add(double.Parse(PanelMostrador.Text));

			contador++;

			PanelMostradorReal.Text = PanelMostradorReal.Text + "-";
			PanelMostrador.Clear();
		}

		private void Multiplicacion_Click(object sender, RoutedEventArgs e)
		{
			operadores.Add("*");
			valores.Add(double.Parse(PanelMostrador.Text));

			contador++;

			PanelMostradorReal.Text = PanelMostradorReal.Text + "*";
			PanelMostrador.Clear();
		}

		private void Division_Click(object sender, RoutedEventArgs e)
		{
			operadores.Add("/");
			valores.Add(double.Parse(PanelMostrador.Text));

			contador++;

			PanelMostradorReal.Text = PanelMostradorReal.Text + "/";
			PanelMostrador.Clear();
		}
	}
}
