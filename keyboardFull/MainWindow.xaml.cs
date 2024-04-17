using keyboardFull;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KV
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyButton[] buttons = new MyButton[47];
        private bool flag = false;
        public MainWindow()
        {
            InitializeComponent();

            buttons[0] = new MyButton("~", "`", tilda);
            buttons[1] = new MyButton("!", "1", one);
            buttons[2] = new MyButton("@", "2", two);
            buttons[3] = new MyButton("#", "3", three);
            buttons[4] = new MyButton("$", "4", four);
            buttons[5] = new MyButton("%", "5", five);
            buttons[6] = new MyButton("^", "6", six);
            buttons[7] = new MyButton("&", "7", seven);
            buttons[8] = new MyButton("*", "8", eight);
            buttons[9] = new MyButton("(", "9", nine);
            buttons[10] = new MyButton(")", "0", zero);
            buttons[11] = new MyButton("_", "-", minus);
            buttons[12] = new MyButton("+", "=", ravno);

            buttons[13] = new MyButton("Q", "q", blockQ);
            buttons[14] = new MyButton("W", "w", blockW);
            buttons[15] = new MyButton("E", "e", blockE);
            buttons[16] = new MyButton("R", "r", blockR);
            buttons[17] = new MyButton("T", "t", blockT);
            buttons[18] = new MyButton("Y", "y", blockY);
            buttons[19] = new MyButton("U", "u", blockU);
            buttons[20] = new MyButton("I", "i", blockI);
            buttons[21] = new MyButton("O", "o", blockO);
            buttons[22] = new MyButton("P", "p", blockP);
            buttons[23] = new MyButton("{", "[", blockOpen);
            buttons[24] = new MyButton("}", "]", blockClose);
            buttons[25] = new MyButton("|", "\\", blockObrSlesh); 

            buttons[26] = new MyButton("A", "a", blockA);
            buttons[27] = new MyButton("S", "s", blockS);
            buttons[28] = new MyButton("D", "d", blockD);
            buttons[29] = new MyButton("F", "f", blockF);
            buttons[30] = new MyButton("G", "g", blockG);
            buttons[31] = new MyButton("H", "h", blockH);
            buttons[32] = new MyButton("J", "j", blockJ);
            buttons[33] = new MyButton("K", "k", blockK);
            buttons[34] = new MyButton("L", "l", blockL);
            buttons[35] = new MyButton(":", ";", blockSemico);
            buttons[36] = new MyButton("\"", "'",blockHeig);

            buttons[37] = new MyButton("Z", "z", blockZ);
            buttons[38] = new MyButton("X", "x", blockX);
            buttons[39] = new MyButton("C", "c", blockC);
            buttons[40] = new MyButton("V", "v", blockV);
            buttons[41] = new MyButton("B", "b", blockB);
            buttons[42] = new MyButton("N", "n", blockN);
            buttons[43] = new MyButton("M", "m", blockM);
            buttons[44] = new MyButton("<", ",", blockDow);
            buttons[45] = new MyButton(">", ".", blockDot);
            buttons[46] = new MyButton("?", "/", blockSlesh);

        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            dificul.Text = polzun.Value.ToString();
        }

        private void Start_button_click(object sender, RoutedEventArgs e)
        {
            Start_button.IsEnabled = false;
            Stop_button.IsEnabled = true;

            VividBlock.Focusable = true;
            VividBlock.Focus();

            Random random = new Random();
            for(int i = 0; i <= polzun.Value; i++)
            {
                int value = random.Next(32,96);
                char a = Convert.ToChar(value);
                FirstBlock.Text += a;
            }
        }

        private void Stop_button_click(object sender, RoutedEventArgs e)
        {
            Start_button.IsEnabled = true;
            Stop_button.IsEnabled = false;
            VividBlock.Focusable = false;
        }
        private void VividBlock_KeyUp(object sender, KeyEventArgs e)
        {
           
            if (e.Key == Key.CapsLock)
            {
                CapsLock.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.Tab)
            {
                Tab.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.LeftShift)
            {
                LShift.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
                if (flag == false)
                {
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].textBlock.Text = buttons[i].upValue;
                    }
                    flag = true;
                }
                else
                {
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].textBlock.Text = buttons[i].downValue;
                    }
                    flag = false;
                }
            }
            if (e.Key == Key.RightShift)
            {
                RShift.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
                if (flag == false)
                {
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].textBlock.Text = buttons[i].upValue;
                    }
                    flag = true;
                }
                else
                {
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].textBlock.Text = buttons[i].downValue;
                    }
                    flag = false;
                }
            }
            if (e.Key == Key.LeftCtrl)
            {
                LCtrl.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.RightCtrl)
            {
                RCtrl.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.LWin)
            {
                LWin.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.RWin)
            {
                RWin.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.RightAlt)
            {
                RAlt.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.LeftAlt)
            {
                LAlt.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.Space)
            {
                Space.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
                // Space.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#ff4a460");
            }
            if (e.Key == Key.OemTilde)
            {
                TildaBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");
                VividBlock.Text += tilda.Text;
            }
            if (e.Key == Key.D0)
            {
                ZeroBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");
                VividBlock.Text += zero.Text;
            }
            if (e.Key == Key.D1)
            {
               Borderone.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");
                VividBlock.Text += one.Text;
            }
            if (e.Key == Key.D2)
            {
               Bordertwo.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");
                VividBlock.Text += two.Text;
            }
            if (e.Key == Key.D3)
            {
               Borderthree.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");
                VividBlock.Text += three.Text;
            }
            if (e.Key == Key.D4)
            {
               fourBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += four.Text;
            }
            if (e.Key == Key.D5)
            {
               FiveBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");
                VividBlock.Text += five.Text;
            }
            if (e.Key == Key.D6)
            {
               SixBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");
                VividBlock.Text += six.Text;
            }
            if (e.Key == Key.D7)
            {
               SevenBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");
                VividBlock.Text += seven.Text;
            }
            if (e.Key == Key.D8)
            {
               EightBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");
                VividBlock.Text += eight.Text;
            }
            if (e.Key == Key.D9)
            {
                NineBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");
                VividBlock.Text += nine.Text;
            }
            if (e.Key == Key.Q)
            {
                qBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");
                VividBlock.Text += blockQ.Text;
            }
            if (e.Key == Key.W)
            {
                wBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");
                VividBlock.Text += blockW.Text;
            }
            if (e.Key == Key.E)
            {
                eBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += blockE.Text;
            }
            if (e.Key == Key.R)
            {
                rBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");
                VividBlock.Text += blockR.Text;
            }
            if (e.Key == Key.T)
            {
                tBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");
                VividBlock.Text += blockT.Text;
            }
            if (e.Key == Key.Y)
            {
                yBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");
                VividBlock.Text += blockY.Text;
            }
            if (e.Key == Key.U)
            {
                uBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");
                VividBlock.Text += blockU.Text;
            }
            if (e.Key == Key.I)
            {
                iBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");
                VividBlock.Text += blockI.Text;
            }
            if (e.Key == Key.O)
            {
                oBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");
                VividBlock.Text += blockO.Text;
            }
            if (e.Key == Key.P)
            {
                pBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += blockP.Text;
            }
            if (e.Key == Key.A)
            {
                aBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");
                VividBlock.Text += blockA.Text;
            }
            if (e.Key == Key.S)
            {
                sBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");
                VividBlock.Text += blockS.Text;
            }
            if (e.Key == Key.D)
            {
                dBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += blockD.Text;
            }
            if (e.Key == Key.F)
            {
                fBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");
                VividBlock.Text += blockF.Text;
            }
            if (e.Key == Key.G)
            {
                gBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");
                VividBlock.Text += blockG.Text;
            }
            if (e.Key == Key.H)
            {
                hBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");
                VividBlock.Text += blockH.Text;
            }
            if (e.Key == Key.J)
            {
                jBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");
                VividBlock.Text += blockJ.Text;
            }
            if (e.Key == Key.K)
            {
                kBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");
                VividBlock.Text += blockK.Text;
            }
            if (e.Key == Key.L)
            {
                lBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");
                VividBlock.Text += blockL.Text; 
            }
            if (e.Key == Key.Z)
            {
                zBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");
                VividBlock.Text += blockZ.Text;
            }
            if (e.Key == Key.X)
            {
                xBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");
                VividBlock.Text += blockX.Text;
            }
            if (e.Key == Key.C)
            {
                cBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += blockC.Text;
            }
            if (e.Key == Key.V)
            {
                vBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");
                VividBlock.Text += blockV.Text;
            }
            if (e.Key == Key.B)
            {
                bBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");
                VividBlock.Text += blockB.Text;
            }
            if (e.Key == Key.N)
            {
                nBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");
                VividBlock.Text += blockN.Text;
            }
            if (e.Key == Key.M)
            {
                mBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");
                VividBlock.Text += blockM.Text;
            }
            if (e.Key == Key.OemSemicolon)
            {
                semicolonBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += blockSemico.Text;
            }
            if (e.Key == Key.OemQuestion)
            {
                sleshBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += blockSlesh.Text;
            }
            if (e.Key == Key.OemComma)
            {
                dowBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#f4a460");
                VividBlock.Text += blockDow.Text;
            }
            if (e.Key == Key.OemPeriod)
            {
                dotBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");
                VividBlock.Text += blockDot.Text;
            }
            if (e.Key == Key.OemOpenBrackets)
            {
                openBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += blockOpen.Text;
            }
            if (e.Key == Key.OemCloseBrackets)
            {
                closeBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += blockClose.Text;
            }
            if (e.Key == Key.OemQuotes)
            {
                heigBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += blockHeig.Text;
            }
            if (e.Key == Key.OemMinus)
            {
                MinusBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += minus.Text;
            }
            if (e.Key == Key.OemPlus)
            {
                EquallyBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += ravno.Text;
            }
            if (e.Key == Key.OemPipe)
            {
                obrsleshBorder.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");
                VividBlock.Text += blockObrSlesh.Text;
            }
            if (e.Key == Key.Enter)
            {
                Enter.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }





        }
        private void VividBlock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                Tab.Background = new SolidColorBrush(Colors.White);
                e.Handled = true;
            }
            if (e.Key == Key.CapsLock) { 
                CapsLock.Background = new SolidColorBrush(Colors.White);
                if(flag == false)
                {
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].textBlock.Text = buttons[i].upValue;
                    }
                    flag = true;
                }
                else
                {
                    for (int i = 0;i < buttons.Length; i++)
                    {
                        buttons[i].textBlock.Text = buttons[i].downValue;
                    }
                    flag = false;
                }
                
            }
            if (e.Key == Key.LeftShift)
            {
                LShift.Background = new SolidColorBrush(Colors.White);
                if (flag == false)
                {
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].textBlock.Text = buttons[i].upValue;
                    }
                    flag = true;
                }
                else
                {
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].textBlock.Text = buttons[i].downValue;
                    }
                    flag = false;
                }
            }
            if (e.Key == Key.RightShift)
            {
                RShift.Background = new SolidColorBrush(Colors.White);
                if (flag == false)
                {
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].textBlock.Text = buttons[i].upValue;
                    }
                    flag = true;
                }
                else
                {
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].textBlock.Text = buttons[i].downValue;
                    }
                    flag = false;
                }
            }
            if (e.Key == Key.LeftCtrl)
            {
                LCtrl.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.RightCtrl)
            {
                RCtrl.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.LWin)
            {
                LWin.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.RWin)
            {
               RWin.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.LeftAlt)
            {
               LAlt.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.RightAlt)
            {
                RAlt.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.Space)
            {
                Space.Background = new SolidColorBrush(Colors.White);
                VividBlock.Text += " ";
            }
            if (e.Key == Key.Back)
            {
                VividBlock.Text = VividBlock.Text.Substring(0, VividBlock.Text.Length - 1);
            }
            if (e.Key == Key.OemTilde)
            {
                TildaBorder.Background = new SolidColorBrush(Colors.White);

            }
            if (e.Key == Key.D0)
            {
                ZeroBorder.Background = new SolidColorBrush(Colors.White);
                VividBlock.Text += zero.Text;
            }
            if (e.Key == Key.D1)
            {
                Borderone.Background = new SolidColorBrush(Colors.White);
               
            }
            if (e.Key == Key.D2)
            {
                Bordertwo.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.D3)
            {
                Borderthree.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.D4)
            {
                fourBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.D5)
            {
                FiveBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.D6)
            {
                SixBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.D7)
            {
                SevenBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.D8)
            {
                EightBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.D9)
            {
                NineBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.Q)
            {
                qBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.W)
            {
                wBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.E)
            {
                eBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.R)
            {
                rBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.T)
            {
                tBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.Y)
            {
                yBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.U)
            {
                uBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.I)
            {
                iBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.O)
            {
                oBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.P)
            {
                pBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.A)
            {
                aBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.S)
            {
                sBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.D)
            {
                dBorder.Background = new SolidColorBrush(Colors.White);
               
            }
            if (e.Key == Key.F)
            {
                fBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.G)
            {
                gBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.H)
            {
                hBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.J)
            {
                jBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.K)
            {
                kBorder.Background = new SolidColorBrush(Colors.White);
                
            }
            if (e.Key == Key.L)
            {
                lBorder.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.Z)
            {
                zBorder.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.X)
            {
                xBorder.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.C)
            {
                cBorder.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.V)
            {
                vBorder.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.B)
            {
                bBorder.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.N)
            {
                nBorder.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.M)
            {
                mBorder.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.Oem1)
            {
                semicolonBorder.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.OemSemicolon)
            {
                semicolonBorder.Background = new SolidColorBrush(Colors.White);
                VividBlock.Text += blockSemico.Text;
            }
            if (e.Key == Key.OemQuestion)
            {
                sleshBorder.Background = new SolidColorBrush(Colors.White);
                VividBlock.Text += blockSlesh.Text;
            }
            if (e.Key == Key.OemComma)
            {
                dowBorder.Background = new SolidColorBrush(Colors.White);
                VividBlock.Text += blockDow.Text;
            }
            if (e.Key == Key.OemPeriod)
            {
                dotBorder.Background = new SolidColorBrush(Colors.White);
                VividBlock.Text += blockDot.Text;
            }
            if (e.Key == Key.OemOpenBrackets)
            {
                openBorder.Background = new SolidColorBrush(Colors.White);
                VividBlock.Text += blockOpen.Text;
            }
            if (e.Key == Key.OemCloseBrackets)
            {
                closeBorder.Background = new SolidColorBrush(Colors.White);
                VividBlock.Text += blockClose.Text;
            }
            if (e.Key == Key.OemQuotes)
            {
                heigBorder.Background = new SolidColorBrush(Colors.White);
                VividBlock.Text += blockHeig.Text;
            }
            if (e.Key == Key.OemMinus)
            {
                MinusBorder.Background = new SolidColorBrush(Colors.White);
                VividBlock.Text += minus.Text;
            }
            if (e.Key == Key.OemPlus)
            {
                EquallyBorder.Background = new SolidColorBrush(Colors.White);
                VividBlock.Text += ravno.Text;
            }
            if (e.Key == Key.OemPipe)
            {
                obrsleshBorder.Background = new SolidColorBrush(Colors.White);
                VividBlock.Text += blockObrSlesh.Text;
            }
            if (e.Key == Key.Enter)
            {
                Enter.Background = new SolidColorBrush(Colors.White);
            }
        }
    }
}
