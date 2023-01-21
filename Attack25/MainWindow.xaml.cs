using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
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

namespace Attack25
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static string mode;

        private void GreenCount_Click(object sender, RoutedEventArgs e)
        {
            GreenCount.BorderBrush = new SolidColorBrush(Colors.Yellow);
            BlueCount.BorderBrush = new SolidColorBrush(Colors.White);
            RedCount.BorderBrush = new SolidColorBrush(Colors.White);
            WhiteCount.BorderBrush = new SolidColorBrush(Colors.Black);
            mode = "Green";
        }

        private void RedCount_Click(object sender, RoutedEventArgs e)
        {
            GreenCount.BorderBrush = new SolidColorBrush(Colors.White);
            BlueCount.BorderBrush = new SolidColorBrush(Colors.White);
            RedCount.BorderBrush = new SolidColorBrush(Colors.Yellow);
            WhiteCount.BorderBrush = new SolidColorBrush(Colors.Black);
            mode = "Red";
        }

        private void WhiteCount_Click(object sender, RoutedEventArgs e)
        {
            GreenCount.BorderBrush = new SolidColorBrush(Colors.White);
            BlueCount.BorderBrush = new SolidColorBrush(Colors.White);
            RedCount.BorderBrush = new SolidColorBrush(Colors.White);
            WhiteCount.BorderBrush = new SolidColorBrush(Colors.Yellow);
            mode = "White";
        }

        private void BlueCount_Click(object sender, RoutedEventArgs e)
        {
            GreenCount.BorderBrush = new SolidColorBrush(Colors.White);
            BlueCount.BorderBrush = new SolidColorBrush(Colors.Yellow);
            RedCount.BorderBrush = new SolidColorBrush(Colors.White);
            WhiteCount.BorderBrush = new SolidColorBrush(Colors.Black);
            mode = "Blue";
        }
        
        private void SwitchCount(string Before, string After)
        {
            switch (Before)
            {
                case "Green":
                    GreenCount.Content = Int32.Parse(GreenCount.Content.ToString()) - 1;
                    break;
                case "Red":
                    RedCount.Content = Int32.Parse(RedCount.Content.ToString()) - 1;
                    break;
                case "White":
                    WhiteCount.Content = Int32.Parse(WhiteCount.Content.ToString()) - 1;
                    break;
                case "Blue":
                    BlueCount.Content = Int32.Parse(BlueCount.Content.ToString()) - 1;
                    break;
            }
            switch (After)
            {
                case "Green":
                    GreenCount.Content = Int32.Parse(GreenCount.Content.ToString()) + 1;
                    PlaySound("Sounds\\Green.wav");
                    break;
                case "Red":
                    RedCount.Content = Int32.Parse(RedCount.Content.ToString()) + 1;
                    PlaySound("Sounds\\Red.wav");
                    break;
                case "White":
                    WhiteCount.Content = Int32.Parse(WhiteCount.Content.ToString()) + 1;
                    PlaySound("Sounds\\White.wav");
                    break;
                case "Blue":
                    BlueCount.Content = Int32.Parse(BlueCount.Content.ToString()) + 1;
                    PlaySound("Sounds\\Blue.wav");
                    break;
            }
        }
        private System.Media.SoundPlayer player = null;

        private void PlaySound(string waveFile)
        {
            //再生されているときは止める
            if (player != null)
                StopSound();

            //読み込む
            player = new System.Media.SoundPlayer(waveFile);
            //非同期再生する
            player.Play();
        }

        //再生されている音を止める
        private void StopSound()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }


        private void Panel1_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel1.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                   BeforeColor = "None";
                    break;
            }

            switch (mode)
            {
                case "Green":
                    AfterColor= "Green";
                    Panel1.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel1.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel1.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel1.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor,AfterColor);
            
        }

        private void Panel2_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel2.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }

            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel2.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel2.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel2.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel2.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);

        }

        private void Panel3_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel3.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }

            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel3.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel3.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel3.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel3.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);

        }

        private void Panel4_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel4.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }

            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel4.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel4.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel4.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel4.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);

        }

        private void Panel5_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel5.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }

            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel5.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel5.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel5.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel5.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);

        }

        private void Panel6_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel6.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }

            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel6.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel6.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel6.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel6.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel7_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel7.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel7.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel7.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel7.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel7.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel8_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel8.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel8.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel8.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel8.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel8.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel9_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel9.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel9.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel9.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel9.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel9.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel10_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel10.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel10.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel10.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel10.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel10.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel11_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel11.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel11.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel11.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel11.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel11.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel12_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel12.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel12.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel12.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel12.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel12.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel13_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel13.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel13.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel13.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel13.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel13.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel14_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel14.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel14.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel14.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel14.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel14.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel15_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel15.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel15.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel15.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel15.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel15.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel16_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel16.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel16.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel16.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel16.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel16.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel17_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel17.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel17.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel17.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel17.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel17.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel18_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel18.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel18.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel18.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel18.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel18.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel19_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel19.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel19.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel19.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel19.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel19.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel20_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel20.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel20.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel20.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel20.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel20.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel21_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel21.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel21.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel21.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel21.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel21.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel22_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel22.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel22.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel22.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel22.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel22.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel23_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel23.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel23.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel23.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel23.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel23.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }


        private void Panel24_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel24.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel24.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel24.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel24.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel24.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void Panel25_Click(object sender, RoutedEventArgs e)
        {
            string BeforeColor = "undefined";
            string AfterColor = "undefined";
            switch (Panel25.Background.ToString())
            {
                case "#FF008000":
                    BeforeColor = "Green";
                    break;
                case "#FFFFFFFF":
                    BeforeColor = "White";
                    break;
                case "#FF0000FF":
                    BeforeColor = "Blue";
                    break;
                case "#FFFF0000":
                    BeforeColor = "Red";
                    break;
                default:
                    BeforeColor = "None";
                    break;
            }
            switch (mode)
            {
                case "Green":
                    AfterColor = "Green";
                    Panel25.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "White":
                    AfterColor = "White";
                    Panel25.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Blue":
                    AfterColor = "Blue";
                    Panel25.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    AfterColor = "Red";
                    Panel25.Background = new SolidColorBrush(Colors.Red);
                    break;
            }
            SwitchCount(BeforeColor, AfterColor);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            var dialogresult = MessageBox.Show("パネルをリセットしますか？", "警告", MessageBoxButton.OKCancel);
            if(dialogresult == MessageBoxResult.Cancel)
            {
                return;
            }
            object obj = System.Windows.Media.ColorConverter.ConvertFromString("#FFDDDDDD");
            Panel1.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel2.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel3.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel4.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel5.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel6.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel7.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel8.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel9.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel10.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel11.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel12.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel13.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel14.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel15.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel16.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel17.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel18.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel19.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel20.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel21.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel22.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel23.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel24.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            Panel25.Background = new SolidColorBrush((System.Windows.Media.Color)obj);
            BlueCount.Content = "0";
            GreenCount.Content = "0";
            WhiteCount.Content = "0";
            RedCount.Content = "0";
        }
    }
}
