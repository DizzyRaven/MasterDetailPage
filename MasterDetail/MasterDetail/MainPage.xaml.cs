using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetail
{
	public partial class MainPage : MasterDetailPage
	{
        public MainPage()
        {
            InitializeComponent();

            //Свойство detailPage, отвечает за ditail страницу(главную, кторая сзади)
            Detail = new NavigationPage(new Page1())
            {
                BarBackgroundColor = Color.DarkOliveGreen//Head color
            };

            //Is presented прячет Master page
            IsPresented = false;

		}
        private void btn1_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page1());
            IsPresented = false;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page2());
            IsPresented = false;
        }
        public void swch1(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                Detail.BackgroundColor = Color.Yellow;
                nm.Text = "On";
            }
            else
            {
                Detail.BackgroundColor = Color.White;
                nm.Text = "Off";
            }
        }
    }
}
