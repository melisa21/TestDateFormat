using System;

namespace Library
{
    public class Date
    {


        public static String ChangeFormatAMD(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }
        public static String ChangeFormatDMA(String year)
        {
            String dateChange;
            if (year.Length==10)
            {
                
                char separador='-';
                int pos = year.IndexOf("-");
                if (pos == -1)
                //el separador es /
                {
                    separador ='/';
                    pos = year.IndexOf("/");
                }

                if (pos==2)
                //recibe XX-XX-XXXX puede ser  MM-DD-AAAA
                {
                    dateChange = year.Substring(3,2) + separador + year.Substring(0,2) + separador + year.Substring(6,4);
                }
                else
                //recibe o AAAA-DD-MM
                {
                    dateChange = year.Substring(5,2) + separador + year.Substring(8,2) + separador + year.Substring(0,4);
                }
            }
            else
            {
                dateChange = "";
            }    
        
            
            return dateChange;
        }


    }
}
