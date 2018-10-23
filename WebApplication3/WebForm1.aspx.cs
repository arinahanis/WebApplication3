using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool IsNumeric(string s)
            {
                double Result;
                return double.TryParse(s, out Result);  // TryParse routines were added in Framework version 2.0.
            }

            string value = "123";
            if (IsNumeric(value))
            {
                float sumOfSeries(double num)
                {
                    float res = 0, fact = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        // fact variable store  
                        // factorial of the i 
                        fact = fact * i;

                        res = res + (i / fact);
                    }
                    return (res);
                    Response.Write("sum" + res);
                }
            }
            else
            {
                Response.Write("The value entered not a number");
            }
                
            }
        }
    }

                
            
            
            
        

     
    

