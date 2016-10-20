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

namespace EncryptionAlgo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        public void textbox1_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.Text = string.Empty;
            textbox.GotFocus -= textbox1_GotFocus;
        }

        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            string unencrypt;
            unencrypt = textboxMessage.Text;
            string message = encrypter(unencrypt);
            output1.Text = message;
            
        }

        private void Decrypt_Click(object sender, RoutedEventArgs e)
        {
            string decrypt;
            decrypt = textboxMessage.Text;
            string message1 = decrypter(decrypt);
            output1.Text = message1;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textboxMessage.Text = "";
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(output1.Text);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            textboxMessage.Text = Clipboard.GetText();
        }


        public static string encrypter(string msg)
        {
            char[] input = msg.ToCharArray();
            char[] message = new char[input.Length];
            Console.WriteLine(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                message[i] = MainWindow.Encryptionconditions(input[i]);
            }
            string end = new string(message);
            return end;
        }

        public static string decrypter(string msg)
        {
            char[] input = msg.ToCharArray();
            char[] message = new char[input.Length];
            Console.WriteLine(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                message[i] = MainWindow.Decryptionconditions(input[i]);
            }
            string end = new string(message);
            return end;
        }

        public static char Encryptionconditions(char letter)
        {
            if (letter == 'a' || letter == 'A')
            {
                letter = 'D';
                return letter;
            }
            if (letter == 'b' || letter == 'B')
            {
                letter = 'E';
                return letter;
            }
            if (letter == 'c' || letter == 'C')
            {
                letter = 'F';
                return letter;
            }
            if (letter == 'd' || letter == 'D')
            {
                letter = 'G';
                return letter;
            }
            if (letter == 'e' || letter == 'E')
            {
                letter = 'H';
                return letter;
            }
            if (letter == 'f' || letter == 'F')
            {
                letter = 'I';
                return letter;
            }
            if (letter == 'g' || letter == 'G')
            {
                letter = 'J';
                return letter;
            }
            if (letter == 'h' || letter == 'H')
            {
                letter = 'K';
                return letter;
            }
            if (letter == 'i' || letter == 'I')
            {
                letter = 'L';
                return letter;
            }
            if (letter == 'j' || letter == 'J')
            {
                letter = 'M';
                return letter;
            }
            if (letter == 'k' || letter == 'K')
            {
                letter = 'N';
                return letter;
            }
            if (letter == 'l' || letter == 'L')
            {
                letter = 'O';
                return letter;
            }
            if (letter == 'm' || letter == 'M')
            {
                letter = 'P';
                return letter;
            }
            if (letter == 'n' || letter == 'N')
            {
                letter = 'Q';
                return letter;
            }
            if (letter == 'o' || letter == 'O')
            {
                letter = 'R';
                return letter;
            }
            if (letter == 'p' || letter == 'P')
            {
                letter = 'S';
                return letter;
            }
            if (letter == 'q' || letter == 'Q')
            {
                letter = 'T';
                return letter;
            }
            if (letter == 'r' || letter == 'R')
            {
                letter = 'U';
                return letter;
            }
            if (letter == 's' || letter == 'S')
            {
                letter = 'V';
                return letter;
            }
            if (letter == 't' || letter == 'T')
            {
                letter = 'W';
                return letter;
            }
            if (letter == 'u' || letter == 'U')
            {
                letter = 'X';
                return letter;
            }
            if (letter == 'v' || letter == 'V')
            {
                letter = 'Y';
                return letter;
            }
            if (letter == 'w' || letter == 'W')
            {
                letter = 'Z';
                return letter;
            }
            if (letter == 'x' || letter == 'X')
            {
                letter = 'A';
                return letter;
            }
            if (letter == 'y' || letter == 'Y')
            {
                letter = 'B';
                return letter;
            }
            if (letter == 'z' || letter == 'Z')
            {
                letter = 'C';
            }
            if (letter == '~')
            {
                letter = '@';
                return letter;
            }
            if (letter == '`')
            {
                letter = '#';
                return letter;
            }
            if (letter == '!')
            {
                letter = '$';
                return letter;
            }
            if (letter == '@')
            {
                letter = '%';
                return letter;
            }
            if (letter == '#')
            {
                letter = '^';
                return letter;
            }
            if (letter == '$')
            {
                letter = '&';
                return letter;
            }
            if (letter == '%')
            {
                letter = '*';
                return letter;
            }
            if (letter == '^')
            {
                letter = '(';
                return letter;
            }
            if (letter == '&')
            {
                letter = ')';
                return letter;
            }
            if (letter == '*')
            {
                letter = '?';
                return letter;
            }
            if (letter == '(')
            {
                letter = '"';
                return letter;
            }
            if (letter == ')')
            {
                letter = '<';
                return letter;
            }
            if (letter == '?')
            {
                letter = '>';
                return letter;
            }
            if (letter == '"')
            {
                letter = '.';
                return letter;
            }
            if (letter == '<')
            {
                letter = ',';
                return letter;
            }
            if (letter == '>')
            {
                letter = ';';
                return letter;
            }
            if (letter == '.')
            {
                letter = ':';
                return letter;
            }
            if (letter == ',')
            {
                letter = '~';
                return letter;
            }
            if (letter == ';')
            {
                letter = '`';
                return letter;
            }
            if (letter == ':')
            {
                letter = '!';
                return letter;
            }
            return letter;
        }
        public static char Decryptionconditions(char letter)
        {
            if (letter == 'a' || letter == 'A')
            {
                letter = 'X';
                return letter;
            }
            if (letter == 'b' || letter == 'B')
            {
                letter = 'Y';
                return letter;
            }
            if (letter == 'c' || letter == 'C')
            {
                letter = 'Z';
                return letter;
            }
            if (letter == 'd' || letter == 'D')
            {
                letter = 'A';
                return letter;
            }
            if (letter == 'e' || letter == 'E')
            {
                letter = 'B';
                return letter;
            }
            if (letter == 'f' || letter == 'F')
            {
                letter = 'C';
                return letter;
            }
            if (letter == 'g' || letter == 'G')
            {
                letter = 'D';
                return letter;
            }
            if (letter == 'h' || letter == 'H')
            {
                letter = 'E';
                return letter;
            }
            if (letter == 'i' || letter == 'I')
            {
                letter = 'F';
                return letter;
            }
            if (letter == 'j' || letter == 'J')
            {
                letter = 'G';
                return letter;
            }
            if (letter == 'k' || letter == 'K')
            {
                letter = 'H';
                return letter;
            }
            if (letter == 'l' || letter == 'L')
            {
                letter = 'I';
                return letter;
            }
            if (letter == 'm' || letter == 'M')
            {
                letter = 'J';
                return letter;
            }
            if (letter == 'n' || letter == 'N')
            {
                letter = 'K';
                return letter;
            }
            if (letter == 'o' || letter == 'O')
            {
                letter = 'L';
                return letter;
            }
            if (letter == 'p' || letter == 'P')
            {
                letter = 'M';
                return letter;
            }
            if (letter == 'q' || letter == 'Q')
            {
                letter = 'N';
                return letter;
            }
            if (letter == 'r' || letter == 'R')
            {
                letter = 'O';
                return letter;
            }
            if (letter == 's' || letter == 'S')
            {
                letter = 'P';
                return letter;
            }
            if (letter == 't' || letter == 'T')
            {
                letter = 'Q';
                return letter;
            }
            if (letter == 'u' || letter == 'U')
            {
                letter = 'R';
                return letter;
            }
            if (letter == 'v' || letter == 'V')
            {
                letter = 'S';
                return letter;
            }
            if (letter == 'w' || letter == 'W')
            {
                letter = 'T';
                return letter;
            }
            if (letter == 'x' || letter == 'X')
            {
                letter = 'U';
                return letter;
            }
            if (letter == 'y' || letter == 'Y')
            {
                letter = 'V';
                return letter;
            }
            if (letter == 'z' || letter == 'Z')
            {
                letter = 'W';
            }
            return letter;
        }



    }
}
