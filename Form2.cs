﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp12
{
    public partial class Form2 : Form
    {
        public Form2(Person person)
        {
            InitializeComponent();
            nameLabel.Text = "Name: " + person.Name;
            ageLabel.Text = "Age: " + person.Age.ToString();
        }
    }

}
