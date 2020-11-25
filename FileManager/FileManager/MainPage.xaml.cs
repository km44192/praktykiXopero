using System;
using System.Collections.Generic;

using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Windows.System;


namespace FileManager
{
    public sealed partial class MainPage : Page
    {
        string textToWrite;
        public MainPage()
        {
            this.InitializeComponent();
        }


        bool textChanged = false;
        bool loading = false;
        IStorageFile saveFile = null;


        private async void Browser()
        {
            FileOpenPicker picker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.List,
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary
            };

            picker.FileTypeFilter.Add(".txt");
            
            IStorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                string fileContents = await FileIO.ReadTextAsync(file);
                textToWrite = fileContents;
                loading = true;
                Contents.Text = textToWrite;
                textChanged = false;
                filename.Text = file.Name;
                saveFile = file;
            }
        


        }

        private async void Saver()
        {
            if (saveFile == null)
            {
                FileSavePicker picker = new FileSavePicker
                {
                    DefaultFileExtension = ".txt",
                    SuggestedStartLocation = PickerLocationId.DocumentsLibrary
                };
                picker.FileTypeChoices.Add("Plik Tekstowy", new List<string>() { ".txt" });
                picker.FileTypeChoices.Add("Pliki dziennika", new List<string>() { ".log", ".dat" });

               saveFile = await picker.PickSaveFileAsync();
                if (saveFile == null) return;
            }
            await FileIO.WriteTextAsync(saveFile, textToWrite);
            await new MessageDialog("Zapisano" + saveFile.Name).ShowAsync();
            textChanged = false;
            filename.Text = saveFile.Name;
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
          
            Saver();
        }

        private async void Files_Click(object sender, RoutedEventArgs e)
        {
            if (textChanged)
            {
                MessageDialog overWriteDialog = new MessageDialog("Plik został zmieniony. Czy na pewno chcesz wczytać nowy plik?");
                overWriteDialog.Commands.Add(new UICommand("Tak"));
                overWriteDialog.Commands.Add(new UICommand("Nie"));
                overWriteDialog.DefaultCommandIndex = 1;
                UICommand result = await overWriteDialog.ShowAsync() as UICommand;
                if (result != null && result.Label == "Nie")
                    return;
                
            }

            Browser();
        }

        private void Contents_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (loading)
            {
                loading = false;
                return;
            }
            if (!textChanged)
            {
                filename.Text += "*";
                Save.IsEnabled = true;
                textChanged = true;
            }
        }
    }
}
