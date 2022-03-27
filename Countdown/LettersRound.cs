using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Countdown
{
    class LettersRound
    {
        Random r = new Random();
        const int AMOUNT_OF_LETTERS = 9;
        public string letters = "";
        string PoolV1 = "АЕИОУ"; //vowels, 2 layers of frequencies
        string PoolV2 = "ЁЮЫЭЯ";
        string PoolC1 = "БВГДКЛМНПРСТ"; //consonants, 3 layers of frequencies
        string PoolC2 = "ЙЗЧ";
        string PoolC3 = "ЪЬФЩШЖХЦ";
        List<string> possibleWords;
        public void AddConsonant()
        {
            if (IsFull()) return;
            double check = r.Next(0, 11);
            if (check > 9)
            {
                int rndLetterC3 = r.Next(PoolC3.Length);
                letters += PoolC3[rndLetterC3];
                return;
            }
            if (check > 5)
            {
                int rndLetterC2 = r.Next(PoolC2.Length);
                letters += PoolC2[rndLetterC2];
                return;
            }
            int rndLetterC1 = r.Next(PoolC1.Length);
            letters += PoolC1[rndLetterC1];
            return;

        }
        public void AddVowel()
        {
            if (IsFull()) return;
            double check = r.Next(0, 10);
            if (check > 7)
            {
                int rndLetterV2 = r.Next(PoolV2.Length);
                letters += PoolV2[rndLetterV2];
                return;
            }
            int rndLetterV1 = r.Next(PoolV1.Length);
            letters += PoolV1[rndLetterV1];
            return;
        }
        public void Clear()
        {
            letters = "";
        }
        public bool CheckAvailability(string inp)
        {
            string ls = letters;
            while (inp != "" && ls != "")
            {
                string current = inp.Substring(0,1);
                if (ls.Contains(current))
                {
                    ls = ls.Remove(ls.IndexOf(current), 1);
                    inp = inp.Remove(0, 1);
                }
                else break;
            }
            if (inp == "") return true; else return false;
        }
        public bool IsFull()
        {
            if (AMOUNT_OF_LETTERS < letters.Length) throw new Exception("ДА КАК????????????");
            return (AMOUNT_OF_LETTERS == letters.Length);
        }
        string Alphabetized(string s)
        {
            char[] chars = s.ToArray();
            Array.Sort(chars);
            return new string(chars);
        }
        bool Contain(string main,string sub) //main - набор букв, саб - слово из словаря
        {
            for (int i = 0; i < sub.Length; i++)
            {
                if (main.IndexOf(sub[i]) != -1)
                {
                    main = main.Remove(main.IndexOf(sub[i]), 1);
                }
                else return false;
            }
            return true;
        }
        public string FindWords(StreamReader list)
        {
            List<string> wordlist = new List<string>();
            string words = "";
            while (!list.EndOfStream)
            {
                string item = list.ReadLine().ToUpper();
                if (item.Length > AMOUNT_OF_LETTERS) continue;
                if (Contain(letters, item)) wordlist.Add(item);
            }
            possibleWords = wordlist;
            string[] arr = wordlist.ToArray();
            Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {

                words += arr[i].ToLower() + "\n";
            }
            return words;
        }
        public bool CheckDictionary(string t)
        {
            return (possibleWords.Contains(t.ToUpper()));
        }
    }
}
