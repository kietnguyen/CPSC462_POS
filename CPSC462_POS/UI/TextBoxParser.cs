using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPSC462_POS.UI
{
    class TextBoxParser
    {
        private static TextBoxParser parser = null;
        private TextBoxParser() { }

        /// <summary>
        /// 
        /// </summary>
        public static TextBoxParser GetInstance
        {
            get
            {
                if (parser == null)
                    parser = new TextBoxParser();
                return parser;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="errMessage"></param>
        /// <param name="defaultIfBlank"></param>
        /// <returns></returns>
        public int tbToInt(TextBox tb, string errMessage = "", bool OneIfBlank = false)
        {
            int num = 0;
            if (tb.Text == "")
                return 1;

            try
            {
                num = Convert.ToInt32(tb.Text);
                tb.Clear();
            }
            catch (FormatException e)
            {
                errMessage = (errMessage.Length > 0 ? errMessage : e.Message);
                MessageBox.Show(errMessage);
            }

            return num;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="errMessage"></param>
        /// <param name="OneIfBlank"></param>
        /// <returns></returns>
        public int tbToPosInt(TextBox tb, string errMessage = "", bool OneIfBlank = false)
        {
            int num = tbToInt(tb, errMessage, OneIfBlank);
            if (num <= 0)
            {
                MessageBox.Show(errMessage);
            }
            return num;
        }

        public decimal tbToDecimal(TextBox tb, string errMessage = "")
        {
            decimal num = 0m;
            if (tb.Text.Length == 0) return num;

            try
            {
                num = Convert.ToDecimal(tb.Text);
                tb.Clear();
            }
            catch (FormatException e)
            {
                errMessage = (errMessage.Length > 0 ? errMessage : e.Message);
                MessageBox.Show(errMessage);
            }

            return num;
        }

        public decimal tbToPosDecimal(TextBox tb, string errMessage = "")
        {
            decimal num = tbToDecimal(tb, errMessage);
            if (num <= 0)
            {
                MessageBox.Show(errMessage);
            }
            return num;
        }
    }
}
