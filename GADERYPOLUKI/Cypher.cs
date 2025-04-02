using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaderypolukiCypher
{
    class Cypher
    {
        public static string DictionaryGaderpoluki(string text)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('A', 'G');
            dict.Add('B', 'B');
            dict.Add('C', 'C');
            dict.Add('D', 'E');
            dict.Add('E', 'D');
            dict.Add('F', 'F');
            dict.Add('G', 'A');
            dict.Add('H', 'H');
            dict.Add('I', 'K');
            dict.Add('J', 'J');
            dict.Add('K', 'I');
            dict.Add('L', 'U');
            dict.Add('M', 'M');
            dict.Add('N', 'N');
            dict.Add('O', 'P');
            dict.Add('P', 'O');
            dict.Add('Q', 'Q');
            dict.Add('R', 'Y');
            dict.Add('S', 'S');
            dict.Add('T', 'T');
            dict.Add('U', 'L');
            dict.Add('V', 'V');
            dict.Add('W', 'W');
            dict.Add('X', 'X');
            dict.Add('Y', 'R');
            dict.Add('Z', 'Z');
            text = text.ToUpper().Replace(" ", "");
            char[] charArray = text.ToCharArray();
            string output = String.Empty;
            foreach (char c in charArray)
            {
                output += dict[c];
            }
            return output;
        }
    }
}