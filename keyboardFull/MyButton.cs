using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace keyboardFull
{
    internal class MyButton
    {
        public string upValue;
        public string downValue;
        public TextBlock textBlock;

        public MyButton(string upValue, string downValue, TextBlock textBlock)
        {
            this.upValue = upValue;
            this.downValue = downValue;
            this.textBlock = textBlock;
        }
    }
}
