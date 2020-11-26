using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace SerializacjaKlasyGuy
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MainPage : SerializacjaKlasyGuy.Common.LayoutAwarePage
    { 
        public MainPage()
        {
            this.InitializeComponent();
        }

       
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

   
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void WriteJoe_Click(object sender, RoutedEventArgs e)
        {
            guyManager.WriteGuyAsync(guyManager.Joe);
        }
        private void WriteBob_Click(object sender, RoutedEventArgs e)
        {
            guyManager.WriteGuyAsync(guyManager.Bob);
        }
        private void WriteEd_Click(object sender, RoutedEventArgs e)
        {
            guyManager.WriteGuyAsync(guyManager.Ed);
        }
        private void ReadNewGuy_Click(object sender, RoutedEventArgs e)
        {
            //guyManager.ReadGuyAsync();
        }
    }
}
