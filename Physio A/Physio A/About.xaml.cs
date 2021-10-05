using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Physio_A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class About : ContentView
    {
        bool ReadMore = false;

        public About()
        {
            InitializeComponent();

            lblReadMore.MaxLines = 4;
        }

        private void btnReadMore_Clicked(object sender, EventArgs e)
        {
            if (ReadMore == true)
            {
                lblReadMore.MaxLines = 30;
                ReadMore = false;
            }
            else
            {
                lblReadMore.MaxLines = 4;
                ReadMore = true;

            }
        }
    }
}