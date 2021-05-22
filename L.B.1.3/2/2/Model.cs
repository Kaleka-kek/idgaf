using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Model
    {
        private int number;
        private int counter;
        private int result;
        public int Plus(string String)
        {
            result = 0;
            string[] splits = String.Split(new char[] { '+' });
            foreach (var split in splits)
            {
                number = int.Parse(split);
                result = result + number;
            }          
            return result;
        }
        public int Minus(string String)
        {
            result = 0;
            counter = 0;
            string[] splits = String.Split(new char[] { '-' });
            foreach (var split in splits)
            {
                number = int.Parse(split);
                if (counter == 1)
                {
                    result = result - number;                
                }               
                else
                {
                    result = number;
                    counter++;
                }
            }
            return result;
        }        
        public int Multiplication(string String)
        {
            result = 0;
            counter = 0;
            string[] splits = String.Split(new char[] { '*' });
            foreach (var split in splits)
            {
                number = int.Parse(split);
                if (counter == 1)
                {
                    result = result * number;
                }
                else
                {
                    result = number;
                    counter++;
                }
            }         
            return result;
        }
        public int Division(string String)
        {
            result = 0;
            counter = 0;
            string[] splits = String.Split(new char[] { '/' });
            foreach(var split in splits)
            {   
                number = int.Parse(split);
                if (counter == 1)
                {
                    result = result / number;
                }
                else
                {
                    result = number;
                    counter++;
                }
            }            
            return result;
        }
    }
}
