using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NotePad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nomeArquivo = "";
        string pastaNotePad = "";

        public MainWindow()
        {
            InitializeComponent();
            string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            pastaNotePad = System.IO.Path.Combine(pastaDocumentos, "Anotacoes");
            Directory.CreateDirectory(pastaNotePad);
        }

        private void txtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtBox.Text.Length > 0)
            {
                txtPlaceholder.Text = "";
            }
            else
            {
                txtPlaceholder.Text = "Digite suas anotações aqui...";
            }
        }

        private void btnSalvarNomeArquivo_Click(object sender, RoutedEventArgs e)
        {
            if(txtNomeArquivo.Text.Length > 0)
            {
                nomeArquivo = txtNomeArquivo.Text;
            }
            else
            {
                string data = System.DateTime.Now.ToString("dd-MM-yy");
                nomeArquivo = $"anotacoes_{data}";
            }

            System.Diagnostics.Debug.WriteLine(nomeArquivo);
        }
    }
}