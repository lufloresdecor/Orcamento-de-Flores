using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Orçamento_Flores.Utils
{
    public static class Utilidades
    {
        public static bool IsFormCompleted<T>(this T form) where T : UserControl
        {
            foreach (var control in form.Controls)
            {
                if(control is TextBox)
                    if ((control as TextBox).Text == "")
                        return false;
                if (control is MaskedTextBox)
                    if (!(control as MaskedTextBox).MaskCompleted)
                        return false;
                if(control is ComboBox)
                    if((control as ComboBox).SelectedItem == null)
                        return false;
            }
            return true;
        }
        public static Font SetBold(this Font font, bool condition)
        {
            if(condition)
                return new Font(font, FontStyle.Bold);
            else
                return new Font(font, FontStyle.Regular);
        }
    }
}
