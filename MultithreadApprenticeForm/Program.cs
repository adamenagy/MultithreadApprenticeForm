using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultithreadApprenticeForm
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }

    internal class AxHostConverter : AxHost
    {
      private AxHostConverter() : base("") { }

      static public stdole.IPictureDisp ImageToPictureDisp(Image image)
      {
        return (stdole.IPictureDisp)GetIPictureDispFromPicture(image);
      }

      static public Image PictureDispToImage(stdole.IPictureDisp pictureDisp)
      {
        return GetPictureFromIPicture(pictureDisp);
      }
    }

    delegate void UpdateInfoDelegate(Label lbl, string info);
    public static void UpdateInfo(Label lbl, string info)
    {
      if (lbl.InvokeRequired)
      {
        lbl.Invoke(new UpdateInfoDelegate(UpdateInfo),
          new object[] { lbl, info }); 
      }
      else
      {
        lbl.Text = info;
      }
    }

    public static void UseApprentice(object obj)
    {
      MainForm form1 = (MainForm)obj;

      Inventor.ApprenticeServerComponent app =
        new Inventor.ApprenticeServerComponent();

      string folder = @"C:\Users\adamnagy\Documents\Inventor";

      UpdateInfo(form1.lblInfo, "Working...");

      string [] files = Directory.GetFiles(folder, "*.ipt");
      int i = 0;
      foreach (string file in files)
      {
        Inventor.ApprenticeServerDocument doc =
          app.Open(file);

        UpdateInfo(form1.lblInfo, "Working..." + (++i).ToString());

        try
        {
          var pic = doc.Thumbnail;
          System.Diagnostics.Debug.WriteLine("Got Thumbnail");

          Image img = AxHostConverter.PictureDispToImage(pic);

          form1.pictureBox.Image = null;
          //System.Threading.Thread.Sleep(100); 
          form1.pictureBox.Image = img;
          //System.Threading.Thread.Sleep(100); 
        }
        catch
        {
          System.Diagnostics.Debug.WriteLine("Oops");
          UpdateInfo(form1.lblInfo, "Oops...");
          return;
        }

        doc.Close();
      }

      UpdateInfo(form1.lblInfo, "Done");
    }
  }
}
