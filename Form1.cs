using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace passwordguess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string gf = bunifuMaterialTextbox1.Text;
            string birth = bunifuMaterialTextbox2.Text;
            string takim = bunifuMaterialTextbox3.Text;
            string parent = bunifuMaterialTextbox4.Text;
            string name = bunifuMaterialTextbox6.Text;
            string luck = bunifuMaterialTextbox7.Text;

            List<string> listim = new List<string>();
            listim.Add(gf);
            listim.Add(birth);
            listim.Add(takim);
            listim.Add(parent);
            listim.Add(name);
            listim.Add(luck);

            List<string> password = new List<string>();
            for(int i=0; i < listim.Count; i++)
            {
                password.Add(listim[i]);
            }
            for(int i=0; i<listim.Count; i++)
            {
                for(int j=0; j<listim.Count; j++)
                {
                    password.Add(listim[i] + listim[j]);
                    password.Add(listim[i] + "." + listim[j]);
                }
            }
            for(int i=0; i<listim.Count; i++)
            {
                for(int j=0; j<listim.Count; j++)
                {
                    for(int z=0; z<listim.Count; z++)
                    {
                        password.Add(listim[i] + listim[j] + listim[z]);
                        password.Add(listim[i] + "." + listim[j] + "." + listim[z]);
                    }
                }
            }
            string dosya_yolu = @"passwords.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for(int a=0; a < password.Count; a++)
            {
                sw.WriteLine(password[a]);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            MessageBox.Show("Hackno iyi günler diler!");

        }
    }
}
