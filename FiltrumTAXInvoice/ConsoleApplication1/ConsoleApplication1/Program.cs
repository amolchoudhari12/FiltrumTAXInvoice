using System;
using System.Collections.Generic;
using System.Text;

namespace FiltrumTaxInvoice.BusinessObjects.Common
{


    public class NumericToWord
    {

        #region Public Methods

        /// <summary>
        /// These method returns currency in rupees
        /// Author : Amol Chouhdrai.
        /// </summary>
        /// <param name="numb"></param>
        /// <returns></returns>

        public String changeNumericToWords(double numb)
        {

            String num = numb.ToString();

            return changeToWords(num, false);

        }

        public String changeCurrencyToWords(String numb)
        {

            return changeToWords(numb, true);

        }

        public String changeNumericToWords(String numb)
        {

            return changeToWords(numb, false);

        }

        public String changeCurrencyToWords(double numb)
        {

            return changeToWords(numb.ToString(), true);

        }

        public double Converter()
        {

            Console.WriteLine("\nEnter your Number : ");
            double number = Convert.ToDouble(Console.ReadLine());


            string outputCurrency1 = changeNumericToWords(number);
            string outputCurrency2 = changeCurrencyToWords(number);

            Console.WriteLine("The currency in Numeric To  words is : {0}ruppes only ", outputCurrency1);
            Console.WriteLine("The currency in Currency To  words is : {0}rupees only\n", outputCurrency1);

            return number;


        }

        #endregion

        #region  Private Methods

        private String changeToWords(String numb, bool isCurrency)
        {

            String val = "", wholeNo = numb, points = "", andStr = "", pointStr = "";

            String endStr = (isCurrency) ? ("Only") : ("");

            try
            {

                int decimalPlace = numb.IndexOf(".");

                if (decimalPlace > 0)
                {

                    wholeNo = numb.Substring(0, decimalPlace);

                    points = numb.Substring(decimalPlace + 1);

                    if (Convert.ToInt32(points) > 0)
                    {

                        andStr = (isCurrency) ? ("and") : ("Rupees And ");// just to separate whole numbers from points/cents

                        endStr = (isCurrency) ? ("Cents " + endStr) : ("");

                        pointStr = translateCents(points);
                        //pointStr = tens(points);
                    }

                }

                val = String.Format("{0} {1}{2} {3}", translateWholeNumber(wholeNo).Trim(), andStr, pointStr, endStr);

            }

            catch { ;}

            return val;

            // int length = val.Split("and", StringSplitOptions.None ).Length;
            // RemoveDoubleAnd();

        }

        private String translateWholeNumber(String number)
        {

            string word = "";

            try
            {

                bool beginsZero = false;//tests for 0XX

                bool isDone = false;//test if already translated

                double dblAmt = (Convert.ToDouble(number));

                //if ((dblAmt > 0) && number.StartsWith("0"))

                if (dblAmt > 0)
                {//test for zero or digit zero in a nuemric

                    beginsZero = number.StartsWith("0");

                    int numDigits = number.Length;
                    int number1 = Convert.ToInt32(number);
                    int numberOfDigits = number1.ToString().Length;

                    int pos = 0;//store digit grouping

                    String place = "";//digit grouping name:hundres,thousand,etc...

                    switch (numDigits)
                    {

                        case 1://ones' range

                            word = ones(number);

                            isDone = true;

                            break;

                        case 2://tens' range

                            word = tens(number);

                            isDone = true;

                            break;

                        case 3://hundreds' range

                            pos = (numDigits % 3) + 1;
                            if (!beginsZero)
                                place = " Hundred ";

                            break;

                        case 4://thousands' range

                        case 5:

                            pos = (numDigits % 4) + 1;
                            if (!beginsZero)
                                place = " Thousand ";
                            else if (numberOfDigits >= 4)
                                place = " Thousand ";

                            break;

                        case 6:



                        case 7://millions' range

                            pos = (numDigits % 6) + 1;
                            if (!beginsZero)
                                place = " Lacs ";
                            else if (numberOfDigits >= 5)
                                place = " Lacs ";

                            break;

                        case 8:
                            pos = (numDigits % 8) + 1;
                            if (!beginsZero)
                                place = " Carore ";
                            else if (numberOfDigits >= 6)
                                place = " Carore ";

                            break;

                        case 9:




                        case 10://Billions's range

                            pos = (numDigits % 10) + 1;

                            if (!beginsZero)
                                place = " Billion ";
                            else if (numberOfDigits >= 7)
                                place = " Billion ";

                            break;

                        //add extra case options for anything above Billion...

                        default:

                            isDone = true;

                            break;

                    }

                    if (!isDone)
                    {//if transalation is not done, continue...(Recursion comes in now!!)

                        word = translateWholeNumber(number.Substring(0, pos)) + place + translateWholeNumber(number.Substring(pos));

                        //check for trailing zeros

                        if (beginsZero)
                        {
                            if (word.EndsWith("and")== true)
                                word = " and " + word.Trim();
                        }


                    }

                    //ignore digit grouping names

                    if (word.Trim().Equals(place.Trim())) word = "";

                }

            }

            catch { ;}

            return word.Trim();

        }

        private String tens(String digit)
        {

            int digt = Convert.ToInt32(digit);

            String name = null;

            switch (digt)
            {

                case 10:

                    name = "Ten";

                    break;

                case 11:

                    name = "Eleven";

                    break;

                case 12:

                    name = "Twelve";

                    break;

                case 13:

                    name = "Thirteen";

                    break;

                case 14:

                    name = "Fourteen";

                    break;

                case 15:

                    name = "Fifteen";

                    break;

                case 16:

                    name = "Sixteen";

                    break;

                case 17:

                    name = "Seventeen";

                    break;

                case 18:

                    name = "Eighteen";

                    break;

                case 19:

                    name = "Nineteen";

                    break;

                case 20:

                    name = "Twenty";

                    break;

                case 30:

                    name = "Thirty";

                    break;

                case 40:

                    name = "Fourty";

                    break;

                case 50:

                    name = "Fifty";

                    break;

                case 60:

                    name = "Sixty";

                    break;

                case 70:

                    name = "Seventy";

                    break;

                case 80:

                    name = "Eighty";

                    break;

                case 90:

                    name = "Ninety";

                    break;

                default:

                    if (digt > 0)
                    {

                        name = tens(digit.Substring(0, 1) + "0") + " " + ones(digit.Substring(1));

                    }

                    break;

            }

            return name;

        }

        private String ones(String digit)
        {

            int digt = Convert.ToInt32(digit);

            String name = "";

            switch (digt)
            {

                case 1:

                    name = "One";

                    break;

                case 2:

                    name = "Two";

                    break;

                case 3:

                    name = "Three";

                    break;

                case 4:

                    name = "Four";

                    break;

                case 5:

                    name = "Five";

                    break;

                case 6:

                    name = "Six";

                    break;

                case 7:

                    name = "Seven";

                    break;

                case 8:

                    name = "Eight";

                    break;

                case 9:

                    name = "Nine";

                    break;

            }

            return name;

        }

        private String translateCents(String cents)
        {

            String cts = "", digit = "", engOne = "";

            for (int i = 0; i < cents.Length; i++)
            {

                digit = cents[i].ToString();

                if (digit.Equals("0"))
                {

                    engOne = "Zero";

                }

                else
                {

                    engOne = ones(digit);

                }

                cts += " " + engOne;

            }

            return translateWholeNumber(cents);

        }

        #endregion


    }










    class Test
    {
        public static void Main()
        {
            NumericToWord nc = new NumericToWord();

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Enter Number :");
                string strinput = Console.ReadLine();
                string str = nc.changeNumericToWords(strinput);
                Console.WriteLine(str + "\n");

            }

        }

    }



}

