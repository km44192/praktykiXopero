using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Sockets;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=234238

namespace TenObcy
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    { int k = 0;
        int ws = 0;
        Random random = new Random();
        DispatcherTimer enemyTimer = new DispatcherTimer();
        DispatcherTimer targetTimer = new DispatcherTimer();
      //  ProgressBar progressBar = new ProgressBar();
        
        bool humanCaptured = false;
        public MainPage()
        {
            
            this.InitializeComponent();
            enemyTimer.Tick += enemyTimer_Tick;
            enemyTimer.Interval = TimeSpan.FromSeconds(2);

            targetTimer.Tick += targetTimer_Tick;
            targetTimer.Interval = TimeSpan.FromSeconds(.1);
            
        }
        private void startButton_Click(object sender, RoutedEventArgs e) {
            StartGame();
            k = 0;
            ws = 0;
        }    

        void enemyTimer_Tick(object sender,object e)
        {
            AddEnemy();
        }
        void targetTimer_Tick(object sender, object e)
        {
            progresBar.Value += 1;
            if (progresBar.Value >= progresBar.Maximum) 
            EndTheGame();
        }

   

        private void AddEnemy()
        {
            ContentControl enemy = new ContentControl();
            enemy.Template = Resources["EnemyTemplate"] as ControlTemplate;
            AnimateEnemy(enemy, 0, playArea.ActualWidth - 100, "(Canvas.Left)");
            AnimateEnemy(enemy, random.Next((int)playArea.ActualHeight - 100), random.Next((int)playArea.ActualHeight - 100), "(Canvas.Top)");
            playArea.Children.Add(enemy);
            ws++;
            enemy.PointerEntered += enemy_PointerEntered;
        }

        private void AnimateEnemy(ContentControl enemy, double from, double to, string propertyAnimate)
        {
            Storyboard storyboard = new Storyboard() { AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = from,
            To = to,
            Duration = new Duration(TimeSpan.FromSeconds(random.Next(4, 6)))
        };
        Storyboard.SetTarget(animation,enemy);
            Storyboard.SetTargetProperty(animation, propertyAnimate);
            storyboard.Children.Add(animation);
            storyboard.Begin();
        
        }
        void EndTheGame() {
            if(!playArea.Children.Contains(gameOverText))
            enemyTimer.Stop();
            targetTimer.Stop();
            humanCaptured = false;
            grastart.Visibility = Visibility.Visible;
            playArea.Children.Add(gameOverText);
        
        }
        private void StartGame() {
            k = 0;
            human.IsHitTestVisible = true;
            humanCaptured = false;
            progresBar.Value = 0;
            grastart.Visibility = Visibility.Collapsed;
            playArea.Children.Clear();
            playArea.Children.Add(target);
            playArea.Children.Add(human);
            enemyTimer.Start();
            targetTimer.Start();
        }
        void enemy_PointerEntered(object sender,PointerRoutedEventArgs e)
        {
            if(humanCaptured)
            EndTheGame();
        }

        private void human_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if(enemyTimer.IsEnabled)
            {
                humanCaptured = true;
                human.IsHitTestVisible = false;

            }
        }

        private void target_PointerEntered(object sender, PointerRoutedEventArgs e)
        {k++;
            TextBox_TextChanged();
            if (targetTimer.IsEnabled && humanCaptured)
            {
                
                progresBar.Value = 0;
                Canvas.SetLeft(target, random.Next(100, (int)playArea.ActualWidth - 100));
                Canvas.SetTop(target, random.Next(100, (int)playArea.ActualHeight - 100));
                Canvas.SetLeft(human, random.Next(100, (int)playArea.ActualWidth - 100));
                Canvas.SetTop(human, random.Next(100, (int)playArea.ActualHeight - 100));
                humanCaptured = false;
                human.IsHitTestVisible = true;
                
            }
        }

        private void playArea_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (humanCaptured)
            {
                Point pointerPosition = e.GetCurrentPoint(null).Position;
                Point relativePosition = grid.TransformToVisual(playArea).TransformPoint(pointerPosition);

            if((Math.Abs(relativePosition.X-Canvas.GetLeft(human))>human.ActualWidth *3) || (Math.Abs(relativePosition.Y - Canvas.GetTop(human))> human.ActualHeight * 3))
                 {
                    humanCaptured = false;
                    human.IsHitTestVisible = true;

                }
            else
                {
                    Canvas.SetLeft(human, relativePosition.X - human.ActualWidth / 2);
                    Canvas.SetTop(human, relativePosition.Y - human.ActualHeight / 2);

                }
            
            } 
                
        }

        private void TextBox_TextChanged()
        {


            punktacja.Text = (k+ws).ToString();
        }
    }

    
   
}
