using System;
using System.Drawing;
using System.Windows.Forms;

namespace Supervisory
{
    public partial class SplashForm: Form
    {
        public SplashForm()
        {
            InitializeComponent();

            //Set the splash screen size
            this.Size = new Size(800, 600); 
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackgroundImage = Image.FromFile("E:/Meus projetos/Visual Studio/Projeto Pessoal/STCSupervisory/Imagens/newlogo.jpg"); // Altere o caminho da logo
            this.BackgroundImageLayout = ImageLayout.Center;
            this.ShowInTaskbar = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Display splash screen for 3 seconds
            Timer timer = new Timer();
            timer.Interval = 3000; 
            timer.Tick += (sender, args) =>
            {
                timer.Stop();
                this.Close();
            };
            timer.Start();
        }
        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
