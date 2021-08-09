using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace propclip_grinding_tracker.Utils
{
    public static class ThreadHelper
    {
        public static T GetValue<E, T>(Form form, E control, Func<E, T> func) where E : Control
        {
            if (control.InvokeRequired)
            {
                T value = default;
                try
                {
                    form.Invoke((MethodInvoker)delegate
                    {
                        value = func(control);
                    });
                }
                catch { }
                return value;
            }
            else
                return func(control);
        }

        public static void ThreadAction(Form form, Action action)
        {
            if (form.InvokeRequired)
                form.Invoke(action);
            else
                action();
        }
    }
}
