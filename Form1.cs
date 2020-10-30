using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class regAlk : Form
    {
        public regAlk()
        {
            InitializeComponent();
        }

        private void hobbikList_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void huzzaadButton_Click(object sender, EventArgs e)
        {

            if (hobbikList.Items.Contains(ujText.Text))
            {
                MessageBox.Show("Ez már szerepel a listában");
          
            }

            else if (string.IsNullOrEmpty(ujText.Text))
                return;
            hobbikList.Items.Add(ujText.Text);
            ujText.Clear();
            ujText.Focus();


        }

        private void ujText_TextChanged(object sender, EventArgs e)
        {


        }

        private void mentesButton_Click(object sender, EventArgs e)
        {
            mentes.InitialDirectory = @"C:\";
            mentes.RestoreDirectory = true;
            mentes.FileName = "*.txt";
            mentes.DefaultExt = "txt";
            mentes.Filter = "txt files (*.txt) | *.txt";

            if (mentes.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = mentes.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);

                sw.Write(nevText.Text);                       
                sw.Write(dateSzül.Value);
                if (radioN.Checked)
                {
                    sw.Write("Nő");
                }
                if (radioF.Checked)
                {
                    sw.Write("Férfi");
                }
                sw.Write(hobbikList.SelectedItem);


                sw.Close();
                fileStream.Close();                                                           
            }        
        }

        private void mentes_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void betoltesButton_Click(object sender, EventArgs e)
        {
            megnyitas.ShowDialog();
            string filename = megnyitas.FileName;
            string readfile = File.ReadAllText(filename);
            nevText.Text = readfile;
        }
    }
}
