using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainProject.Util
{
    internal class KeyPressUtil
    {
        public static void Int(TextBox tb, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
            }
            else
            {
                if (e.KeyChar == '\b')
                {
                }
                else
                {
                    if (tb.Text.Trim().Length == 0)
                    {
                        tb.Text = "0";
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        public static void Double(TextBox tb, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    if (tb.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (e.KeyChar == '\b')
                    {
                    }
                    else
                    {
                        if (tb.Text.Trim().Length == 0)
                        {
                            tb.Text = "0";
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }

        public static void PhoneNumber(String str, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
            }
            else
            {
                if (e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == '-' || e.KeyChar == '+')
                {
                    if (str.Contains('+') || str.Contains('(') || str.Contains(')'))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (e.KeyChar == '\b')
                    {
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        public static void NumberCode(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
            }
            else
            {
                if (e.KeyChar == '-')
                {
                }
                else
                {
                    if (e.KeyChar == '\b')
                    {
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
