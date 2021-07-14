using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleFormsApp
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         if (lblHello.Text.Length == 0)
         {
            lblHello.Text = "Hello World!";
         }
         else
         {
            lblHello.Text = "";
         }
      }
   }
}
