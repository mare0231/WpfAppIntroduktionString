﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppIntroduktionString.IO
{
    public class ClassIO
    {
        public ClassIO()
        {

        }

        public void GetTestString(TextBox textBox)
        {
            using (StreamReader streamReader = new StreamReader(@"..\..\Txt\Admiralen.txt"))
            {
                textBox.Text = streamReader.ReadToEnd();
            }
        }
    }
}
