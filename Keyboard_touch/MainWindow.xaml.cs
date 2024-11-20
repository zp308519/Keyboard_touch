using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Speech.Synthesis;


namespace Keyboard_touch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += SS_KeyDown;
        }

        #region Varialbes
        int i = 0;
        int currentK = 0;
        bool K_keyPressed = false;
        bool KW_keyPressed = false;
        bool KA_keyPressed = false;
        SpeechSynthesizer synth = new SpeechSynthesizer();

        #endregion
        private async void SS_KeyDown(object sender, KeyEventArgs e)
        {

            synth.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en-US"));
            
            Button[] buttons_Keyboard = {b_0,b_1,b_2,b_3,b_4,b_5,b_6,b_7,b_8,
                b_9,b_Q,b_W,b_E,b_R,b_T,b_Y,b_U,b_I,b_O,b_P,b_A,
                b_S,b_D,b_F,b_G,b_H,b_J,b_K,b_L,b_Enter,b_Z,b_X,b_C,b_V,b_B,b_N,b_M,b_Przecinek,b_Kropka,b_Enter,b_RemoveAll,
                b_Spacja,b_Backspace, b_Read};

            #region Key A
            if (e.Key == Key.A)
            {
                K_keyPressed = true;
                while (i <= 44)
                {
                    if (i == currentK && i < 44)
                    {
                        switch (i)
                        {
                            case 0:
                                SpeakEverything("zero 1");
                                break;
                            case 1:
                                SpeakEverything("one 1");
                                break;
                            case 2:
                                SpeakEverything("two 1");
                                break;
                            case 3:
                                SpeakEverything("three 2");
                                break;
                            case 4:
                                SpeakEverything("four 10");
                                break;
                            case 5:
                                SpeakEverything("five 3");
                                break;
                            case 6:
                                SpeakEverything("six 5");
                                break;
                            case 7:
                                SpeakEverything("seven 1");
                                break;
                            case 8:
                                SpeakEverything("eight 1");
                                break;
                            case 9:
                                SpeakEverything("nine 1");
                                break;
                            case 10:
                                SpeakEverything("Q 4");
                                break;
                            case 11:
                                SpeakEverything("W 7");
                                break;
                            case 12:
                                SpeakEverything("EEE 1");
                                break;
                            case 13:
                                SpeakEverything("R 10");
                                break;
                            case 14:
                                SpeakEverything("Tea 7");
                                break;
                            case 15:
                                SpeakEverything("why 5");
                                break;
                            case 16:
                                SpeakEverything("you 5");
                                break;
                            case 17:
                                SpeakEverything("I 2");
                                break;
                            case 18:
                                SpeakEverything("O 4");
                                break;
                            case 19:
                                SpeakEverything("Pee 4");
                                break;
                            case 20:
                                synth.SpeakAsync("A");
                                break;
                            case 21:
                                SpeakEverything("es 3");
                                break;
                            case 22:
                                SpeakEverything("Dee 4");
                                break;
                            case 23:
                                SpeakEverything("eff 6");
                                break;
                            case 24:
                                SpeakEverything("gee 3");
                                break;
                            case 25:
                                SpeakEverything("H 6");
                                break;
                            case 26:
                                SpeakEverything("Jey 3");
                                break;
                            case 27:
                                SpeakEverything("K 3");
                                break;
                            case 28:
                                SpeakEverything("L 1");
                                break;
                            case 29:
                                SpeakEverything("enter 1");
                                break;
                            case 30:
                                SpeakEverything("Z 3");
                                break;
                            case 31:
                                SpeakEverything("Ex 2");
                                break;
                            case 32:
                                SpeakEverything("C 3");
                                break;
                            case 33:

                                SpeakEverything("Vee 18");
                                break;
                            case 34:
                                SpeakEverything("Bee 3");
                                break;
                            case 35:
                                SpeakEverything("N 5");
                                break;
                            case 36:
                                SpeakEverything("M 16");
                                break;
                            case 37:
                                SpeakEverything("comma 1");
                                break;
                            case 38:
                                SpeakEverything("point 5");
                                break;
                            case 39:
                                SpeakEverything("enter 1");
                                break;
                            case 40:
                                SpeakEverything("remove all 5");
                                break;
                            case 41:
                                SpeakEverything("space 2");
                                break;
                            case 42:
                                SpeakEverything("backspace 3");
                                break;
                            case 43:
                                SpeakEverything("read 2");
                                break;
                        }
                        buttons_Keyboard[i].Background = Brushes.Red;
                        
                            if (i == 0)
                            {
                                var bc = new BrushConverter();
                                buttons_Keyboard[43].Background = (Brush)bc.ConvertFrom("#78f7ff");
                            }
                            else
                            {
                                buttons_Keyboard[i - 1].Background = Brushes.AntiqueWhite;
                            }
                        i++;
                        break;
                    }
                    else if (i == 44)
                    {
                        i = 0;
                        currentK = 0;
                        buttons_Keyboard[43].Background = Brushes.AntiqueWhite;
                    }

                }
                K_keyPressed = false;
                currentK++;
                await Task.Run(() => { while (!K_keyPressed) ; });
            }
            #endregion

            #region Key W
            if (e.Key == Key.W)
            {
                KW_keyPressed = true;
                    
                for (int i = 0; i < buttons_Keyboard.Length; i++)
                {
                    if (i == currentK-1)
                    {
                        switch (i)
                        {
                            case 0:
                                AddLetter(0, "0");
                                SpeakChosen(synth, "0");
                                break;
                            case 1:
                                AddLetter(0, "1");
                                SpeakChosen(synth, "1");
                                break;
                            case 2:
                                AddLetter(0, "2");
                                SpeakChosen(synth, "2");
                                break;
                            case 3:
                                AddLetter(0, "3");
                                SpeakChosen(synth, "3");
                                break;
                            case 4:
                                AddLetter(0, "4");
                                SpeakChosen(synth, "4");
                                break;
                            case 5:
                                AddLetter(0, "5");
                                SpeakChosen(synth, "5");
                                break;
                            case 6:
                                AddLetter(0, "6");
                                SpeakChosen(synth, "6");
                                break;
                            case 7:
                                AddLetter(0, "7");
                                SpeakChosen(synth, "7");
                                break;
                            case 8:
                                AddLetter(0, "8");
                                SpeakChosen(synth, "8");
                                break;
                            case 9:
                                AddLetter(0, "9");
                                SpeakChosen(synth, "9");
                                break;
                            case 10:
                                AddLetter(0, "Q");
                                SpeakChosen(synth, "Q");
                                break;
                            case 11:
                                AddLetter(0, "W");
                                SpeakChosen(synth, "W");
                                break;
                            case 12:
                                AddLetter(0, "E");
                                SpeakChosen(synth, "E");
                                break;
                            case 13:
                                AddLetter(0, "R");

                                SpeakChosen(synth, "R");
                                break;
                            case 14:
                                AddLetter(0, "T");
                                SpeakChosen(synth, "T");
                                break;
                            case 15:
                                AddLetter(0, "Y");
                                SpeakChosen(synth, "Y");
                                break;
                            case 16:
                                AddLetter(0, "U");
                                SpeakChosen(synth, "U");
                                break;
                            case 17:
                                AddLetter(0, "I");
                                SpeakChosen(synth, "I");
                                break;
                            case 18:
                                AddLetter(0, "O");
                                SpeakChosen(synth, "O");
                                break;
                            case 19:
                                AddLetter(0, "P");
                                SpeakChosen(synth, "P");
                                break;
                            case 20:
                                AddLetter(0, "A");
                                SpeakChosen(synth, "A");
                                break;
                            case 21:
                                AddLetter(0, "S");
                                SpeakChosen(synth, "S");
                                break;
                            case 22:
                                AddLetter(0, "D");
                                SpeakChosen(synth, "D");
                                break;
                            case 23:
                                AddLetter(0, "F");
                                SpeakChosen(synth, "F");
                                break;
                            case 24:
                                AddLetter(0, "G");
                                SpeakChosen(synth, "G");
                                break;
                            case 25:
                                AddLetter(0, "H");
                                SpeakChosen(synth, "H");
                                break;
                            case 26:
                                AddLetter(0, "J");
                                SpeakChosen(synth, "J");
                                break;
                            case 27:
                                AddLetter(0, "K");
                                SpeakChosen(synth, "K");
                                break;
                            case 28:
                                AddLetter(0, "L");
                                SpeakChosen(synth, "0");
                                break;
                            case 29:
                                AddLetter(0, "\n");
                                SpeakChosen(synth, "ENTER");
                                break;
                            case 30:
                                AddLetter(0, "Z");
                                SpeakChosen(synth, "Z");
                                break;
                            case 31:
                                AddLetter(0, "X");
                                SpeakChosen(synth, "X");
                                break;
                            case 32:
                                AddLetter(0, "C");
                                SpeakChosen(synth, "C");
                                break;
                            case 33:
                                AddLetter(0, "V");
                                SpeakChosen(synth, "V");
                                break;
                            case 34:
                                AddLetter(0, "B");
                                SpeakChosen(synth, "B");
                                break;
                            case 35:
                                AddLetter(0, "N");
                                SpeakChosen(synth, "N");
                                break;
                            case 36:
                                AddLetter(0, "M");
                                SpeakChosen(synth, "M");
                                break;
                            case 37:
                                AddLetter(0, ",");
                                SpeakChosen(synth, "COMA");
                                break;
                            case 38:
                                AddLetter(0, ".");
                                SpeakChosen(synth, "POINT");
                                break;
                            case 39:
                                AddLetter(0, "\n");
                                SpeakChosen(synth, "ENTER");
                                break;
                            case 41:
                                AddLetter(0, " ");
                                SpeakChosen(synth, "SPACE");
                                break;
                            case 40:
                                RemoveAll();
                                break;
                            case 42:
                                
                                RemoveLetter(synth);
                                break;
                            case 43:
                                if (output_Text.Text == "")
                                {
                                    synth.SpeakAsync("Please enter some text");
                                }
                                else
                                {
                                    synth.SpeakAsync("Your text is:" + $"{output_Text.Text}");
                                }
                                
                                break;

                        }
                        buttons_Keyboard[i].Background = Brushes.GreenYellow;
                    }
                }
                KW_keyPressed = false;
                
                await Task.Run(() => { while (!KW_keyPressed) ; });
            }
            #endregion

            #region Key S
            if (e.Key == Key.S)
            {
                KA_keyPressed = true;
                
                    if (i == currentK && i > 1)
                    {
                        switch (i -2)
                        {
                        case 0:
                            SpeakEverything("zero 1");
                            break;
                        case 1:
                            SpeakEverything("one 1");
                            break;
                        case 2:
                            SpeakEverything("two 1");
                            break;
                        case 3:
                            SpeakEverything("three 2");
                            break;
                        case 4:
                            SpeakEverything("four 10");
                            break;
                        case 5:
                            SpeakEverything("five 3");
                            break;
                        case 6:
                            SpeakEverything("six 5");
                            break;
                        case 7:
                            SpeakEverything("seven 1");
                            break;
                        case 8:
                            SpeakEverything("eight 1");
                            break;
                        case 9:
                            SpeakEverything("nine 1");
                            break;
                        case 10:
                            SpeakEverything("Q 4");
                            break;
                        case 11:
                            SpeakEverything("W 7");
                            break;
                        case 12:
                            SpeakEverything("EEE 1");
                            break;
                        case 13:
                            SpeakEverything("R 10");
                            break;
                        case 14:
                            SpeakEverything("Tea 7");
                            break;
                        case 15:
                            SpeakEverything("why 5");
                            break;
                        case 16:
                            SpeakEverything("you 5");
                            break;
                        case 17:
                            SpeakEverything("I 2");
                            break;
                        case 18:
                            SpeakEverything("O 4");
                            break;
                        case 19:
                            SpeakEverything("Pee 4");
                            break;
                        case 20:
                            synth.SpeakAsync("A");
                            break;
                        case 21:
                            SpeakEverything("es 3");
                            break;
                        case 22:
                            SpeakEverything("Dee 4");
                            break;
                        case 23:
                            SpeakEverything("eff 6");
                            break;
                        case 25:
                            SpeakEverything("H 6");
                            break;
                        case 26:
                            SpeakEverything("Jey 3");
                            break;
                        case 27:
                            SpeakEverything("K 3");
                            break;
                        case 28:
                            SpeakEverything("L 1");
                            break;
                        case 29:
                            SpeakEverything("enter 3");
                            break;
                        case 30:
                            SpeakEverything("Z 3");
                            break;
                        case 31:
                            SpeakEverything("Ex 2");
                            break;
                        case 32:
                            SpeakEverything("C 3");
                            break;
                        case 33:
                            SpeakEverything("Vee 18");
                            break;
                        case 34:
                            SpeakEverything("Bee 3");
                            break;
                        case 35:
                            SpeakEverything("N 5");
                            break;
                        case 36:
                            SpeakEverything("M 16");
                            break;
                        case 37:
                            SpeakEverything("comma 1");
                            break;
                        case 38:
                            SpeakEverything("point 5");
                            break;
                        case 39:
                            SpeakEverything("enter 1");
                            break;
                        case 40:
                            SpeakEverything("remove all 5");
                            break;
                        case 41:
                            SpeakEverything("space 2");
                            break;
                        case 42:
                            SpeakEverything("backspace 3");
                            break;
                        case 43:
                            SpeakEverything("read 2");
                            break;


                    }


                        if (i == 0 )
                        {
                            var bc = new BrushConverter();
                            buttons_Keyboard[43].Background = (Brush)bc.ConvertFrom("#78f7ff");
                        }
                        else
                        {
                            buttons_Keyboard[i - 2].Background = Brushes.Red;

                            if (i != 45) 
                            {
                                buttons_Keyboard[i - 1].Background = Brushes.AntiqueWhite;
                                var bc1 = new BrushConverter();
                                buttons_Keyboard[43].Background = (Brush)bc1.ConvertFrom("#78f7ff");
                            }
                        }
                        
                        i--;
                    }
                    else if (i == 1)
                    {
                        i = 44;
                        currentK = 45;
                        buttons_Keyboard[0].Background = Brushes.AntiqueWhite;
                        buttons_Keyboard[43].Background = Brushes.Red;
                        synth.SpeakAsync("READ");
                    }
                
                KA_keyPressed = false;
                currentK--;
                await Task.Run(() => { while (!KA_keyPressed) ; });
            }
            #endregion

        }

        #region Methods
        private void AddLetter(int index, string letter)
        {
            output_Text.Text = output_Text.Text + $"{letter}";
        }
        private void RemoveLetter(SpeechSynthesizer synth)
        {
            string previousText = output_Text.Text.ToString();
            int lengthPreviousText = previousText.Length;
            if(output_Text.Text != "")
            {
                
                synth.SpeakAsync("You've removed " + $"{previousText[lengthPreviousText-1].ToString()}");
                output_Text.Text = previousText.Remove(lengthPreviousText - 1);
            }
            else
            {
                synth.SpeakAsync("There's nothing to remove");
            }
            
        }

        private void RemoveAll()
        {
            if(output_Text.Text != "")
            {
                output_Text.Text = "";
                synth.SpeakAsync("You've removed all");
            }
            else
            {
                synth.SpeakAsync("There's nothing to remove");
            }
            
        }
        private void SpeakChosen(SpeechSynthesizer synth,string letter)
        {
            
            synth.SpeakAsync("You've chosen " + letter);
        }
        private void SpeakEverything(string letter)
        {
            player.SoundLocation = @"C:\Users\zuza7\OneDrive\Pulpit\Comiunicator_sounds\" + letter + ".wav";
            player.Load();
            player.Play();
        }

        #endregion
    }
}
