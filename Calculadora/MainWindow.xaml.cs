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

namespace Calculadora
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
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
		}

		private void Uno_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "1";
		}

		private void Dos_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "2";
		}

		private void Tres_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "3";
		}

		private void Cuatro_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "4";
		}

		private void Cinco_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "5";
		}

		private void Seis_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "6";
		}

		private void Siete_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "7";
		}

		private void Ocho_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "8";
		}

		private void Nueve_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + "9";
		}

		private void Coma_Click(object sender, RoutedEventArgs e)
		{
			PanelMostrador.Text = PanelMostrador.Text + ",";
		}

		private void Suma_Click(object sender, RoutedEventArgs e)
		{
			operador = "+";
			primerVal = double.Parse(PanelMostrador.Text);
			PanelMostrador.Clear();
		}

		private void Resta_Click(object sender, RoutedEventArgs e)
		{
			operador = "-";
			primerVal = double.Parse(PanelMostrador.Text);
			PanelMostrador.Clear();
		}

		private void Multiplicacion_Click(object sender, RoutedEventArgs e)
		{
			operador = "*";
			primerVal = double.Parse(PanelMostrador.Text);
			PanelMostrador.Clear();
		}

		private void Division_Click(object sender, RoutedEventArgs e)
		{
			operador = "/";
			primerVal = double.Parse(PanelMostrador.Text);
			PanelMostrador.Clear();
		}
	}
}
