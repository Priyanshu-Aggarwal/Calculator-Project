using System;
namespace Calculator
{
    sealed class CalculatorDevice
    {
        public dynamic Add<T> (T num1, T num2)
        {
            if (num1 is Int32)
            {              
                return Convert.ToInt32(num1) + Convert.ToInt32(num2);
            }
            else if (num1 is double)
            {
                return Convert.ToDouble(num1) + Convert.ToDouble(num2);
            }
            else if (num1 is string)
            {
                return StringCheck(num1.ToString(), num2.ToString(), "+");

            }
            return "";
        }
        public dynamic Subtract<T>(T num1, T num2)
        {
            if (num1 is Int32)
            {
                return Convert.ToInt32(num1) - Convert.ToInt32(num2);
               
            }
            else if (num1 is double)
            {
                return Convert.ToDouble(num1) - Convert.ToDouble(num2);

            }
            else if (num1 is string)
            {
                return StringCheck(num1.ToString(), num2.ToString(), "-");

            }
            return "";
        }
        public dynamic Divide<T>(T num1, T num2)
        {
          

            if (num1 is Int32)
            {
                if(Convert.ToInt32(num1) == 0)
                {
                    return "Not Possible to Divide by Zero!!";
                }
                return Convert.ToInt32(num1) / Convert.ToInt32(num2);
            }
            else if (num1 is double)
            {
                if (Convert.ToDouble(num1) == 0)
                {
                    return "Not Possible to Divide by Zero!!";
                }
                return Convert.ToDouble(num1) / Convert.ToDouble(num2);

            }
            else if (num1 is string)
            {
                return StringCheck(num1.ToString(), num2.ToString(), "/");

            }
            return "";
        }
        public dynamic Multiply<T>(T num1, T num2) 
        {
            
            if(num1 is Int32)
            {
                return Convert.ToInt32(num1) / Convert.ToInt32(num2);
               
            }
            else if(num1 is double)
            {
                return Convert.ToDouble(num1) / Convert.ToDouble(num2);
            }
            else if(num1 is string)
            {
                return StringCheck(num1.ToString(), num2.ToString(), "*");
               
            }
            return "";           
        }


        private dynamic StringCheck(string a, string b, string op)
        {
            int intNum1, intNum2;
            double doubleNum1, doubleNum2;
                       

            if ((int.TryParse(a.ToString(), out intNum1)) && (int.TryParse(b.ToString(), out intNum2)))
            {
               
                switch (op) {
                    case "+": return intNum1 + intNum2;
                    case "*": return intNum1 * intNum2;
                    case "-": return intNum1 - intNum2;
                    case "/":
                        {
                            if (intNum1 == 0)
                            {
                                return "Not Posible to Divide by Zero";
                            }
                            return intNum1 / intNum2;
                        }
                }                
            }

            else if ((double.TryParse(a.ToString(), out doubleNum1)) && (double.TryParse(b.ToString(), out doubleNum2)))
            {
                
                switch (op)
                {
                    case "+": return doubleNum1 + doubleNum2;
                    case "*": return doubleNum1 * doubleNum2;
                    case "-": return doubleNum1 - doubleNum2;
                    case "/":
                        {
                            if (intNum1 == 0)
                            {
                                return "Not Possible to Divide by Zero";
                            }
                            return doubleNum1 / doubleNum2;
                        }
                }
            }

            return "Not Possible to Perform Arithmetic Operation!!";
        }


     }
}
