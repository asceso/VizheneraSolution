using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VizheneraApp
{
    public partial class MainForm : Form
    {
        #region Инициализация и конструктор
        /// <summary>
        /// Массив символов
        /// </summary>
        private static char[] alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя ,".ToCharArray();
        /// <summary>
        /// Массив бинарных значений символов
        /// </summary>
        private static Dictionary<char, string> binary_alphabet = new();
        /// <summary>
        /// Зашифрованная строка
        /// </summary>
        private static string DecodeStringResult = string.Empty;
        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            #region Заполняем бинарные значения
            int start_binary = 0;
            foreach (char sym in alphabet)
            {
                binary_alphabet.Add(sym, Convert.ToString(start_binary, 2).PadLeft(8, '0'));
                start_binary++;
            }
            #endregion
            #region Стандартные тексты в форме
            alphabetLabel.Text += "\"";
            foreach (char sym in alphabet) alphabetLabel.Text += sym;
            alphabetLabel.Text += "\"";
            encodeSecretWord.Text = "имбирь";
            decodeSecretWord.Text = "имбирь";

            encodeInput.Text = "Клара украла у карла коралы ,а хорек украл трусы";
            #endregion
        } 
        #endregion
        #region Логика управления на форме
        /// <summary>
        /// Кнопка кодирования
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">параметр</param>
        private void encodeButton_Click(object sender, EventArgs e)
        {
            string secret = GetSecretStringByLength(encodeSecretWord.Text);
            DecodeStringResult = string.Empty;
            for (int i = 0; i < encodeInput.Text.Length; i++)
            {
                char[] secret_alphabet = GetSecretAlphabet(secret[i]);
                DecodeStringResult += secret_alphabet[GetIndexOfSym(alphabet, encodeInput.Text[i])];
            }
            encodeResult.Text = isBinaryView.Checked ? ToBinaryString(DecodeStringResult) : DecodeStringResult;
        }
        /// <summary>
        /// Кнопка декодирования
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">параметр</param>
        private void decodeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DecodeStringResult))
            {
                MessageBox.Show("Нет зашифрованной строки");
                return;
            }
            string secret = GetSecretStringByLength(decodeSecretWord.Text);
            for (int i = 0; i < DecodeStringResult.Length; i++)
            {
                char[] secret_alphabet = GetSecretAlphabet(secret[i]);
                decodeResult.Text += alphabet[GetIndexOfSym(secret_alphabet, DecodeStringResult[i])];
            }
        }
        /// <summary>
        /// Переключатель бинарного и обычного вида
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">параметр</param>
        private void isBinaryView_CheckedChanged(object sender, EventArgs e) => encodeResult.Text = isBinaryView.Checked ? ToBinaryString(DecodeStringResult) : DecodeStringResult;
        /// <summary>
        /// Приведение в нижний регистр
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">параметр</param>
        private void TextInputToLower(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                tb.Text = tb.Text.ToLower();
            }
        }
        #endregion
        #region Методы кодирования / декодирования
        private string ToBinaryString(string target)
        {
            string result = string.Empty;
            foreach (char sym in target)
                result += binary_alphabet[sym];
            return result;
        }
        private string GetSecretStringByLength(string secret_word)
        {
            int encode_string_length = encodeInput.Text.Length;

            int start_index = 0;
            string result = string.Empty;
            for (int i = 0; i < encode_string_length; i++)
            {
                if (start_index > secret_word.Length - 1) start_index = 0;
                result += secret_word[start_index++];
            }
            return result;
        }
        private int GetIndexOfSym(char[] source, char target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        private char[] GetSecretAlphabet(char start_key)
        {
            string offset_alphabet = string.Empty;
            int index_of_start_key = 0;
            //ищем начало
            for (int i = 0; i < alphabet.Length; i++)
                if (alphabet[i] == start_key) index_of_start_key = i;
            //правая сторона
            for (int i = 0; i < alphabet.Length; i++)
                if (i > index_of_start_key) offset_alphabet += alphabet[i];
            //левая сторона
            for (int i = 0; i < alphabet.Length; i++)
                if (i <= index_of_start_key) offset_alphabet += alphabet[i];
            return offset_alphabet.ToCharArray();
        }
        #endregion
    }
}
