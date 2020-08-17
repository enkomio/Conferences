using EncryptD;
using EncryptID;
using EncryptM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloutusActivator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert install date (format: dd/mm):");
            var dateString = Console.ReadLine();
            var items = dateString.Split('/');
            var day = Int32.Parse(items[0]);
            var month = Int32.Parse(items[1]);
            
            Console.Write("Insert ATMID:");
            var atmId = Console.ReadLine();

            var activationCode = Activate(atmId, day, month);
            Console.WriteLine("Activation code: " + activationCode);
            Console.ReadLine();
        }

        public static String Activate(String atmId, int day, int month)
        {
            ulong num = 0UL;
            int num2 = ClassEncryptID.EncryptID(atmId);
            int num3 = ClassEncryptD.EncryptDay(day);
            int num4 = ClassEncryptM.EncryptMoth(month);
            if (num2 < 0)
            {
                num2 += num2;
            }
            if (num3 < 0)
            {
                num3 += num3;
            }
            if (num4 < 0)
            {
                num4 += num4;
            }
            if (day == 0)
            {
                num = (ulong)((long)(num2 + num3 + num4));
            }
            else if (day >= 1 && day <= 6)
            {
                num = (ulong)((long)(num2 + num3 + num4 + month * 4));
            }
            else if (day >= 7 && day <= 13)
            {
                num = (ulong)((long)(num2 + num3 + num4 + day * 3));
            }
            else if (day >= 14 && day <= 20)
            {
                num = (ulong)((long)(num2 + num3 + num4 + day * month));
            }
            else if (day >= 21 && day <= 27)
            {
                num = (ulong)((long)(num2 + num3 + num4 + (day * month + 7)));
            }
            else if (day >= 28 && day <= 31)
            {
                num = (ulong)((long)(num2 + num3 + num4 + day * month * 3));
            }
            if (num > 99999999UL)
            {
                string text = num.ToString();
                string s = text.Substring(text.Length - 8, 8);
                num = ulong.Parse(s);
            }
            string text2 = num.ToString();
            while (text2.Length < 8)
            {
                text2 = "0" + text2;
            }
            return text2;
        }
    }
}
