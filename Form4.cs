﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_1
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			label1.Text = "Добрый день," + Form1.USER.name + "!";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
			Form1.FORMA.Show();
		}
	}
}