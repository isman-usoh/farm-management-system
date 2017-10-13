using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainProject.Util
{
    internal class ValidatingUtil
    {
        public static void Validating(TextBox tc, Int32 Length, CancelEventArgs e)
        {
            ValidatingUtil.Validating(tc, Length, "จำเป็น", e);
        }

        public static void Validating(TextBox tc, Int32 Length, String message, CancelEventArgs e)
        {
            ValidatingUtil.Validating(tc, tc.Text.Trim().Length == Length, message, e);
        }




        public static void Validating(IWin32Window window, Boolean result, CancelEventArgs e)
        {
            ValidatingUtil.Validating(window, result, "จำเป็น", e);
        }

        public static void Validating(IWin32Window window, Boolean result, String message, CancelEventArgs e)
        {
            if (result)
            {
                var tip = new ToolTip();
                tip.Show(message, window, 5000);
                e.Cancel = true;
            }
        }
    }
}
