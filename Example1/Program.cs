using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextGenerator textGenerator = new TextGenerator();

            while (true)
            {
                string t = Console.ReadLine();
                var text = new Text
                {
                    Value = t,
                    IsAdditionalSpacesRemoved = false,
                    IsFirstLettersToUpperCase = false
                };
                textGenerator.AddToFullText(text);
                Console.WriteLine(textGenerator.FullText);

            }
           
        }
    }

    class TextGenerator
    {
        private string _fullText = "";

        public string FullText
        {
            get
            {
                return this._fullText;
            }
        }

        #region 1. Verilmiş cümlədəki əlavə boşluqları silən metod yazın
        [Obsolete]
        public void RemoveAdditionalSpaces(string text) // Gulsen
        {
            text = text.Trim();

            string result = text[0].ToString();

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i - 1] == ' ' & text[i] == ' ')
                    continue;
                result += text[i];
            }

        }

        [Obsolete]
        static string TrimText(string x) // Murad
        {
            string[] text = x.Split();
            string trimtext = null;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != "")
                {
                    if (i != text.Length - 1)
                    {
                        trimtext += text[i] + " ";
                    }
                    else if (i == text.Length - 1)
                    {
                        trimtext += text[i];
                    }
                }
            }
            return trimtext;
        }

        [Obsolete]
        public string RemoveAdditionalSpacesWithRegex(string text) // Taleh
        {
            var regex = new Regex(@"(\s{2,})");

            return regex.Replace(text, " ").Trim();
        }

        [Obsolete]
        static string ElaveBosluqSil(string str) // Umud
        {
            int a = str.Length;
            for (int i = 0; i < a;)
            {
                if ((str.Substring(i, 1) == " " // str[i].ToString()
                    && str.Substring(i + 1, 1) == " ") // str[i + 1].ToString()
                    || (str.Substring(i, 1) == " " // str[i].ToString()
                    && i == 0))
                {
                    str = str.Remove(i, 1);
                    a--;
                }
                else
                {
                    i++;
                }
            }

            return str;
        }

        public void RemoveAddSpaces(Text text)
        {
            var value = text.Value;
            value = value.Trim();
            var words = value.Split();
            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (string.IsNullOrEmpty(words[i])
                    | string.IsNullOrWhiteSpace(words[i]))
                    continue;
                result += words[i] + " "; // .Trim()
            }

            value = result.TrimEnd();

            text.Value = value;
            text.IsAdditionalSpacesRemoved = true;
        }
        #endregion

        #region 2. Verilmiş cümlədəki bütün sözlərin baş hərfini uppercase edən metod yazın

        public void ToUpperCase(Text text)
        {
            var words = text.Value.Split();

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i])
                    & !string.IsNullOrWhiteSpace(words[i]))
                {
                    var firstLetter = words[i][0].ToString();
                    words[i] = words[i].Remove(0, 1).Insert(0, firstLetter.ToUpper());
                }
            }
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (string.IsNullOrEmpty(words[i])
                    | string.IsNullOrWhiteSpace(words[i]))
                    continue;
                result += words[i] + " "; // .Trim()
            }

            text.Value = result.TrimEnd();

            text.IsFirstLettersToUpperCase = true;
        }

        #endregion

        #region 3. Yuxarıdakı əməliyyatlardan keçən cümlələri toparlayıb bi mətn edən metod yazın. 

        public void AddToFullText(Text text)
        {
            this.RemoveAddSpaces(text);
            this.ToUpperCase(text);

            if (text.IsAdditionalSpacesRemoved & text.IsFirstLettersToUpperCase)
            {
                this._fullText += text.Value + "\n";
            }
        }

        #endregion
    }

    class Text
    {
        public string Value { get; set; }
        public bool IsAdditionalSpacesRemoved { get; set; }
        public bool IsFirstLettersToUpperCase { get; set; }

    }
}
