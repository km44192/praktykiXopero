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
using System.Drawing;


namespace Gra_przygodowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game game;
        private Random random = new Random();
        private Player player;
       
        public MainWindow()
        {
            InitializeComponent();
            game = new Game(new System.Drawing.Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            player = new Player(game, game.PlayerLocation);
            icep.IsEnabled = false;
            isword.IsEnabled = false;
            PHealth.Content = player.HitPoints;
            GHealth.Content = "0";
            Nhealth.Content = "0";
            UHealth.Content = "0";
            Canvas.SetLeft(Player, game.PlayerLocation.X);
            Canvas.SetTop(Player, game.PlayerLocation.Y);
            
        }
        //Atak
        private void Right1_Click(object sender, RoutedEventArgs e)
        {
            player.Attack(Direction.Right, random);
        }

        private void Left1_Click(object sender, RoutedEventArgs e)
        {
            player.Attack(Direction.Left, random);
        }

        private void Top1_Click(object sender, RoutedEventArgs e)
        {
            player.Attack(Direction.Up, random);
        }

        private void Down1_Click(object sender, RoutedEventArgs e)
        {
            player.Attack(Direction.Down, random);
        }
        //Sterowanie
        private void Top_Click(object sender, RoutedEventArgs e)
        {
            player.Move(Direction.Up);
            Canvas.SetTop(Player, player.Location.Y);

        }
       
        private void Down_Click(object sender, RoutedEventArgs e)
        {
        
            player.Move(Direction.Down);
            Canvas.SetTop(Player, player.Location.Y);
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            player.Move(Direction.Right);
            Canvas.SetLeft(Player, player.Location.X);
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            player.Move(Direction.Left);
            Canvas.SetLeft(Player, player.Location.Y);
        }
    }
}
