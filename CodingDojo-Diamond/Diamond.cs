using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo_Diamond
{
    public class Diamond
    {
        public static string Create(char c)
        {
            if (c < 'A' || c > 'Z') { return ""; }
            if (c == 'A') { return "A"; }
            string ret = "";
            for (int spaces = 0; spaces < c - 'A'; spaces++)
            {
                ret += ' ';
            }
            ret += 'A';
            for (int spaces = 0; spaces < c - 'A'; spaces++)
            {
                ret += ' ';
            }
            ret += '\n';
            for (int i='B'; i<c; i++)
            {
                for (int spaces = 0; spaces < c - i; spaces++)
                {
                    ret += ' ';
                }
                ret += (char)i;
                for (int spaces = 0; spaces <= 2 * (i-'B'); spaces++)
                {
                    ret += ' ';
                }
                ret += (char)i;
                for (int spaces = 0; spaces < c - i; spaces++)
                {
                    ret += ' ';
                }
                ret += '\n';
            }
            ret += c;
            for (int spaces = 0; spaces <= 2 * (c-'B'); spaces++)
            {
                ret += ' ';
            }
            ret += c + "\n";
            for (int i = c - 1; i > 'A'; i--)
            {
                for (int spaces = 0; spaces < c - i; spaces++)
                {
                    ret += ' ';
                }
                ret += (char)i;
                for (int spaces = 0; spaces <= 2 * (i - 'B'); spaces++)
                {
                    ret += ' ';
                }
                ret += (char)i;
                for (int spaces = 0; spaces < c - i; spaces++)
                {
                    ret += ' ';
                }
                ret += '\n';
            }
            for (int spaces = 0; spaces < c - 'A'; spaces++)
            {
                ret += ' ';
            }
            ret += 'A';
            for (int spaces = 0; spaces < c - 'A'; spaces++)
            {
                ret += ' ';
            }
            return ret;
        }
    }
}
