﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultithreadApprenticeForm
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void buttonThread_Click(object sender, EventArgs e)
    {
      Thread t = new Thread(new ParameterizedThreadStart(
        Program.UseApprentice));

      // Make sure to set the apartment state BEFORE starting the thread
      // Some info about STA:
      // http://blogs.msdn.com/b/jfoscoding/archive/2005/04/07/406341.aspx
      t.SetApartmentState(ApartmentState.STA);
      t.Start(this);
    }

    private void buttonNoThread_Click(object sender, EventArgs e)
    {
      Program.UseApprentice(this);
    }

    // Copy the given file 100 times so that we have files to ietrate through
    private void btnCopy_Click(object sender, EventArgs e)
    {
      string folder = @"C:\Users\adamnagy\Documents\Inventor\";
      string file = @"SplineTube.ipt";
      for (int i = 0; i < 100; i++)
      {
        File.Copy(folder + file, folder + i.ToString() + file); 
      }
    }
  }
}
