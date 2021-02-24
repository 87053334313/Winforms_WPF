﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace NCommand
{
    class CustomCommands
    {
        public static RoutedUICommand Launch { get; }
        static CustomCommands() 
        {
            InputGestureCollection myInputGesture = new InputGestureCollection();
            myInputGesture.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            Launch = new RoutedUICommand("Запуск", "Launch", typeof(CustomCommands), myInputGesture);
        }
    }
}
