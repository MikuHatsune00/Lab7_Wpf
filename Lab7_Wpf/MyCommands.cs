using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab7_Wpf
{
    class MyCommands
    { 
        public static RoutedUICommand Close { get; set; }

        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            Close = new RoutedUICommand("Закрыть","Close",typeof(MyCommands),inputs);
        }



    }
}
