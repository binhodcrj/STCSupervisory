using System;
using System.Windows.Forms;

namespace Supervisory
{
    static class Program
    {
      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           

            //Display the splash screen
            SplashForm splash = new SplashForm();
            splash.Show();

            //Charging time
            System.Threading.Thread.Sleep(3000); 

           
            Application.Run(new formSTCSupervisory()); 
        }
    }
}
