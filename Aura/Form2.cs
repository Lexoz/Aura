using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aura
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            

            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Magenta;
            TransparencyKey = Color.Magenta;
            InitializeComponent();
            int sW = Screen.PrimaryScreen.Bounds.Width;
            int sH = Screen.PrimaryScreen.Bounds.Height;
            this.Size = new Size(sW / 10, sH);
            this.Location = new Point(sW - (sW / 10), 0);
            this.StartPosition = FormStartPosition.Manual;
            int busize = sH / 12 - 1;
            int busPos = busize + 1;
            button1.Height = busize; button1.Width = busize; button1.Location = new Point((this.Width * 54) / 100, busPos * 0);
            button2.Height = busize; button2.Width = busize; button2.Location = new Point((this.Width * 54) / 100, busPos * 1);
            button3.Height = busize; button3.Width = busize; button3.Location = new Point((this.Width * 54) / 100, busPos * 2);
            button4.Height = busize; button4.Width = busize; button4.Location = new Point((this.Width * 54) / 100, busPos * 3);
            button5.Height = busize; button5.Width = busize; button5.Location = new Point((this.Width * 54) / 100, busPos * 4);
            button6.Height = busize; button6.Width = busize; button6.Location = new Point((this.Width * 54) / 100, busPos * 5);
            button7.Height = busize; button7.Width = busize; button7.Location = new Point((this.Width * 54) / 100, busPos * 6);
            button8.Height = busize; button8.Width = busize; button8.Location = new Point((this.Width * 54) / 100, busPos * 7);
            button9.Height = busize; button9.Width = busize; button9.Location = new Point((this.Width * 54) / 100, busPos * 8);
            button10.Height = busize; button10.Width = busize; button10.Location = new Point((this.Width * 54) / 100, busPos * 9);
            button11.Height = busize; button11.Width = busize; button11.Location = new Point((this.Width * 54) / 100, busPos * 10);
            button12.Height = busize; button12.Width = busize; button12.Location = new Point((this.Width * 54) / 100, busPos * 11);
            button12.Height = busize; button12.Width = busize; button12.Location = new Point((this.Width * 54) / 100, busPos * 11);
            button13.Height = ((busize + 1) * 2) - 1; button13.Width = ((busize + 1) / 2 - 1); button13.Location = new Point((this.Width * 20) / 100, busPos * 0);
            button14.Height = ((busize + 1) * 2) - 1; button14.Width = ((busize + 1) / 2 - 1); button14.Location = new Point((this.Width * 20) / 100, busPos * 2);
            button15.Height = ((busize + 1) * 2) - 1; button15.Width = ((busize + 1) / 2 - 1); button15.Location = new Point((this.Width * 20) / 100, busPos * 4);
            button16.Height = ((busize + 1) * 2) - 1; button16.Width = ((busize + 1) / 2 - 1); button16.Location = new Point((this.Width * 20) / 100, busPos * 6);
            button17.Height = ((busize + 1) * 2) - 1; button17.Width = ((busize + 1) / 2 - 1); button17.Location = new Point((this.Width * 20) / 100, busPos * 8);
            button18.Height = ((busize + 1) * 2) - 1; button18.Width = ((busize + 1) / 2 - 1); button18.Location = new Point((this.Width * 20) / 100, busPos * 10);
            button19.Height = busize; button19.Width = ((busize + 1) / 5 - 1); button19.Location = new Point((this.Width * 45) / 100, busPos * 0);
            button20.Height = busize; button20.Width = ((busize + 1) / 5 - 1); button20.Location = new Point((this.Width * 45) / 100, busPos * 1);
            button21.Height = busize; button21.Width = ((busize + 1) / 5 - 1); button21.Location = new Point((this.Width * 45) / 100, busPos * 2);
            button22.Height = busize; button22.Width = ((busize + 1) / 5 - 1); button22.Location = new Point((this.Width * 45) / 100, busPos * 3);
            button23.Height = busize; button23.Width = ((busize + 1) / 5 - 1); button23.Location = new Point((this.Width * 45) / 100, busPos * 4);
            button24.Height = busize; button24.Width = ((busize + 1) / 5 - 1); button24.Location = new Point((this.Width * 45) / 100, busPos * 5);
            button25.Height = busize; button25.Width = ((busize + 1) / 5 - 1); button25.Location = new Point((this.Width * 45) / 100, busPos * 6);
            button26.Height = busize; button26.Width = ((busize + 1) / 5 - 1); button26.Location = new Point((this.Width * 45) / 100, busPos * 7);
            button27.Height = busize; button27.Width = ((busize + 1) / 5 - 1); button27.Location = new Point((this.Width * 45) / 100, busPos * 8);
            button28.Height = busize; button28.Width = ((busize + 1) / 5 - 1); button28.Location = new Point((this.Width * 45) / 100, busPos * 9);
            button29.Height = busize; button29.Width = ((busize + 1) / 5 - 1); button29.Location = new Point((this.Width * 45) / 100, busPos * 10);
            button30.Height = busize; button30.Width = ((busize + 1) / 5 - 1); button30.Location = new Point((this.Width * 45) / 100, busPos * 11);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            Form1 forma = new Form1();
            this.Dispose();
            forma.Show();

            Form1 forme = new Form1();
            forme.Dispose();
            
            
        }

        //Parameter override from: 
        // https://social.msdn.microsoft.com/forums/windows/en-us/0eefb6f4-3619-4f7a-b144-48df80e2c603/how-to-hide-form-from-alttab-dialog
        protected override CreateParams CreateParams
        {
            get
            {
                // Turn on WS_EX_TOOLWINDOW style bit
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000080;
                return cp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Documents\AuraDockFolders\Models");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Documents\AuraDockFolders\Art");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Documents\AuraDockFolders\Music");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Documents\AuraDockFolders\Projects");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Documents\AuraDockFolders\Maps");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Documents\AuraDockFolders\Diagrams");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Documents\AuraDockFolders\GS DOCS");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Documents\AuraDockFolders\InsaneBump2");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Documents");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Pictures");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Music");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Steam\steamapps\common"); 
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Steam\Steam.exe");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\CCleaner\CCleaner64.exe");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Nexus Mod Manager\NexusClient.exe"); 
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Malwarebytes\Anti-Malware\mbam.exe"); 
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\LibreOffice 5\program\swriter.exe"); 
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Documents\AuraDockFolders\InsaneBump2\InsaneBump.exe");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Notepad++\notepad++.exe"); 
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\LibreOffice 5\program\sdraw.exe");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\ArcGIS\Desktop10.4\bin\ArcMap.exe");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Unity\Editor\Unity.exe");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\LMMS\lmms.exe");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\GIMP 2\bin\gimp-2.8.exe");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Blender Foundation\Blender\blender.exe");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\Documents\quickb\Firefox.exe");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\iTunes\iTunes.exe");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\AppData\Roaming\Curse Client\Bin\Curse.exe");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\lexoz\eclipse\java-neon\eclipse\eclipse.exe");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe");
        }
    }
}
