using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloudExplorerExodus.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotasViewPage : ContentPage
	{
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notas.txt");
		public NotasViewPage ()
		{
			InitializeComponent ();
            if (File.Exists(_fileName))
            {
                ENota.Text = File.ReadAllText(_fileName);
            }
		}

        private void BtnNota_Clicked(object sender, EventArgs e)
        {
            File.WriteAllText(_fileName, ENota.Text);
        }

        private void Mostrarbtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}