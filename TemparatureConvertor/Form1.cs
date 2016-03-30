using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemparatureConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// button click for converting f to c
        /// </summary>
          private void btnFtoC_Click(object sender, EventArgs e)
        {
            //convert FtoC
            string sInputData = "";
            string sOutputData = "";
            double dTempInF = 0;

            sInputData = txtFtoC.Text;

           double.TryParse(sInputData, out dTempInF);// test this works properly
            sOutputData = ConvertFtoC(dTempInF);

            lblFtoC.Text = sOutputData;

        }

        /// <summary>
        /// function converts f to c
        /// </summary>
        /// <param name="dTempInF">Double temp in f</param>
        /// <returns>string value converted from f to c</returns>
        private string ConvertFtoC(double dTempInF)
        {
            string sConvertedValue = "";

            dTempInF = (dTempInF - 32) * .5556;

            sConvertedValue = dTempInF.ToString();

            return sConvertedValue;
        }

        /// <summary>
        /// button handler for c to f
        /// </summary>
        private void btnCtoF_Click(object sender, EventArgs e)
        {
            //Convert c to f
            string sInputData = "";
            string sOutputData = "";
            double dTempInC = 0;

            sInputData = txtCtoF.Text;

            double.TryParse(sInputData, out dTempInC);// test this works properly
            sOutputData = ConvertCtoF(dTempInC);

            lblCtoF.Text = sOutputData;
        }

        /// <summary>
        /// function for converting c to f
        /// </summary>
        /// <param name="dTempInC">Double temp in c</param>
        /// <returns>String Converted Temp</returns>
        private string ConvertCtoF(double dTempInC)
        {
            string sConvertedValue = "";

            dTempInC = (dTempInC * 1.8) +32;

            sConvertedValue = dTempInC.ToString();

            return sConvertedValue;
        }

        /// <summary>
        /// button handler for creating list(needs to be renamed)
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            //list y increments of 10
           // int[] numbers;
            List<string> termsList = new List<string>();
            //loop from 1 to 100
            for (int i = 0; i < 101; i++)
            {
                // if number ends in 0
                if ((i % 10) == 0)
                {
                    string sOutput = ConvertCtoF(i);
                    termsList.Add(String.Format(i.ToString() + " = " + sOutput +"\n"));
                   
                    // add to array

                }
            }
            string test = "";
            foreach (var s in termsList)
            {
                test = test + s;
                label3.Text = test;
               // display each
            }
           

            

        }
    }
}
