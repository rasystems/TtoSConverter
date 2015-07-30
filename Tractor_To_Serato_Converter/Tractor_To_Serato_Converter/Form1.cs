using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Tractor_To_Serato_Converter
{

    public partial class Form1 : Form
    {

        App.Classes.Dataholder Data1 = new App.Classes.Dataholder();
        App.Classes.XMLFunctions Xml1 = new App.Classes.XMLFunctions();
        List<String> TmpTraktorDatabaseList = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          openFileDialog1.ShowDialog();
          Data1.SetTraktorInputFile(openFileDialog1.FileName);
          textBox1.Text = Data1.GetTraktorInputFilePath();
          Xml1.LoadXmlFile(Data1.GetTraktorInputFilePath());
          TmpTraktorDatabaseList = Xml1.GetTraktorListElement();

          for (int i=0;i<TmpTraktorDatabaseList.Count; i++)
          {
             richTextBox1.AppendText(TmpTraktorDatabaseList.ElementAt(i)+"\n");
          }
         
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
