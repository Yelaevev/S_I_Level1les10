using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string BigMinus(string s1, string s2)
        {
            string Answer = "!";
            string zero = "0";
            bool FlagSolve = true;
            bool FlagCondition = true;

            if ((s1 == null) || (s2 == null))
            {
                string Notcorrect = "Initial conditions is not correct";
                    return Notcorrect;
            }
            if (s1 == s2)
            {
                return zero;
            }

            if (s1.Length > s2.Length)
            {
                FlagCondition = true;
            }

            if (s1.Length < s2.Length)
            {
                FlagCondition = false;
            }

            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] > s2[i])
                    {
                        FlagCondition = true;
                        break;
                    }
                    if (s1[i] < s2[i])
                    {
                        FlagCondition = false;
                        break;
                    }
                }
                
            }

            if (((s1.Length == s2.Length)) && (s1[0] < s2[0]))
            {
                FlagCondition = false;
            }
            int S1Number;
            int S2Number;
            int ans;

            if (FlagCondition)
            {
                for (int i = 0; i < s2.Length; i++)
                {
                    //int S1Number;
                    //int S2Number;
                    //int ans;

                    S2Number = int.Parse(s2[s2.Length - 1 - i].ToString());
                    S1Number = s1[s1.Length - 1 - i] - '0';
                    //Console.WriteLine(S1Number);
                    //Console.WriteLine();
                    //Console.WriteLine(S2Number);
                    if (!FlagSolve)
                    {
                        S1Number = S1Number - 1;
                        FlagSolve = true;
                    }

                    if (S2Number > S1Number)
                    {
                        S1Number = S1Number + 10;
                        FlagSolve = false;
                    }
                    ans = S1Number - S2Number;
                    Answer = Answer.Insert(0, Convert.ToString(ans));
                    //Console.Write(Answer);




                }

                for (int i = s2.Length + 1; i <= s1.Length; i++)
                {
                    if (!FlagSolve)
                    {
                        int check = s1.Length - i;
                        S1Number = s1[s1.Length - i] - '0';
                        S1Number = S1Number - 1;
                        FlagSolve = true;
                        Answer = Answer.Insert(0, Convert.ToString(S1Number));

                    }

                    else Answer = Answer.Insert(0, Convert.ToString(s1[s1.Length - i]));
                }

            }

            if (!FlagCondition)
            {

                for (int i = 0; i < s1.Length; i++)
                {
                    //int S1Number;
                    //int S2Number;
                    //int ans;

                    S1Number = int.Parse(s1[s1.Length - i - 1].ToString());
                    S2Number = s2[s2.Length - i - 1] - '0';
                    //Console.WriteLine(S1Number);
                    //Console.WriteLine();
                    //Console.WriteLine(S2Number);
                    if (!FlagSolve)
                    {
                        S2Number = S2Number - 1;
                        FlagSolve = true;
                    }

                    if (S1Number > S2Number)
                    {
                        S2Number = S2Number + 10;
                        FlagSolve = false;
                    }
                    ans = S2Number - S1Number;
                    Answer = Answer.Insert(0, Convert.ToString(ans));

                }

                for (int i = s1.Length + 1; i <= s2.Length; i++)
                {
                    if (!FlagSolve)
                    {
                        int check = s2.Length - i;
                        S2Number = s2[s2.Length - i] - '0';
                        S2Number = S2Number - 1;
                        FlagSolve = true;
                        Answer = Answer.Insert(0, Convert.ToString(S2Number));

                    }

                    else Answer = Answer.Insert(0, Convert.ToString(s2[s2.Length - i]));
                }
            }
            //Console.WriteLine(Answer);
            for (int i = 0; i < Answer.Length-1; i++)
            {
                if (Answer[i] != '0') break; 
                while (Answer[i] == '0') 
                {
                    Answer = Answer.Remove(i, 1);
                    
                } 
            }
            Answer = Answer.Remove(Answer.Length - 1, 1);

            return Answer;
        }

        //static void Main(string[] args)
        //{
        //    string s1 = "1234567891";
        //    string s2 = "1";
        //    Console.WriteLine(s1 + "=значение первой строки");
        //    Console.WriteLine(s2 + "=значение второй строки");
        //    double d1 = Convert.ToDouble(s1);
        //    double d2 = Convert.ToDouble(s2);
        //    d1 = d1 - d2;

        //    string Answer = BigMinus(s1, s2);
        //    //Console.WriteLine(Answer);
        //    //Answer = Answer.Remove(Answer.Length - 1, 1);
        //    Console.WriteLine(Answer + "=BigMinus");
        //    Console.WriteLine(d1 + "=проверка разности через double");
        //    Console.WriteLine(Answer[Answer.Length - 1] + "= последний элемент проверка на ");
        //}
    }
}
