using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace DependencyPropertyExample
{
    class NewTestControl:FrameworkElement
    {
        public static DependencyProperty testDataProperty;
        
        static NewTestControl()
        {
            testDataProperty = DependencyProperty.Register("TestData", typeof(int), typeof(NewTestControl));
        }

        public int TestData
        {
            get
            {
                return (int)GetValue(testDataProperty);
            }
            set
            {
                SetValue(testDataProperty, value);
            }
        }
    }
}
