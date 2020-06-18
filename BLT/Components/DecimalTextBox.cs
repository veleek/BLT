using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BLT.Components
{
    public class DecimalTextBox : TextBox
    {
        public DecimalTextBox()
            : base()
        {
            Initialize();
        }

        private void Initialize()
        {
            SetEventRule();
            Text = Decimal.Zero.ToString();
        }

        private void SetEventRule()
        {
            this.KeyPress += new KeyPressEventHandler(DecimalTextBox_KeyPress);
        }

        void DecimalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!e.KeyChar.Equals(BACKSPACE_CHAR))
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == '.') && Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
        }

        public Decimal Value
        {
            get
            {
                Decimal value = Decimal.Zero;

                if (Text.Length > 0)
                {
                    if (!Decimal.TryParse(Text, out value))
                    {
                        throw new ArgumentOutOfRangeException("text");
                    }

                    value = Decimal.Round(value, Constants.DECIMAL_POINT_PRECISION);
                }

                return value;
            }
        }

        private static char BACKSPACE_CHAR = '\b';
    }
}
