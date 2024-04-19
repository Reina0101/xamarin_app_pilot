using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private List<string> itemList;
        public MainPage()
        { 
            InitializeComponent();
        }

        
        public void AddClicked(object sender, ClickedEventArgs e)
        {
            if (itemList == null)
                itemList = new List<string>();
            itemList.Add(NameEntry.Text);
        }

        public void ShowClicked(object sender, ClickedEventArgs e)
        {
            Navigation.PushAsync(new ListViewPage1());
        }
        
    }
}





