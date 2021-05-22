using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2
{
    class Presenter
    {
        string result;
        Model model = new Model();
        public delegate string ClickEvent(string String);
        public event ClickEvent Click;               
        public string OperationDefine(string String)
        {
            if (Regex.IsMatch(String, @"[+]")) result = model.Plus(String).ToString();
            if (Regex.IsMatch(String, @"[-]")) result = model.Minus(String).ToString();
            if (Regex.IsMatch(String, @"[*]")) result = model.Multiplication(String).ToString();
            if (Regex.IsMatch(String, @"[/]")) result = model.Division(String).ToString();
            return result;
        }
    }
}
