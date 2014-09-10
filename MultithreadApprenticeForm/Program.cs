using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    public static void UseApprentice(object obj)
    {
      MainForm form1 = (MainForm)obj;

      Inventor.ApprenticeServerComponent app =
        new Inventor.ApprenticeServerComponent();

      for (int i = 0; i < 10; i++)
      {
        Inventor.ApprenticeServerDocument doc =
          app.Open(@"C:\Users\adamnagy\Documents\Inventor\boxes.iam");

        try
        {
          var pic = doc.Thumbnail;
          System.Diagnostics.Debug.WriteLine("Got Thumbnail");

          Image img = AxHostConverter.PictureDispToImage(pic);

          form1.pictureBox.Image = null;
          System.Threading.Thread.Sleep(500); 
          form1.pictureBox.Image = img;
          System.Threading.Thread.Sleep(500); 
        }
        catch
        {
          System.Diagnostics.Debug.WriteLine("Oops"); 
        }

        doc.Close();
      }
    }
  }
}
