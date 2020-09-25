using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VirtualKeyboard
{
    public class VKeyboard : Control
    {
        static VKeyboard()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VKeyboard), new FrameworkPropertyMetadata(typeof(VKeyboard)));
        }
    }
}
