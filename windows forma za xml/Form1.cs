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

namespace windows_forma_za_xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadxmlButton_Click(object sender, EventArgs e)
        {
            ////string filePath = @" C:\Users\Ana\Documents\Visual Studio 2013\Projects\windows forma za xml\windows forma za xml\FilesFromDrive.xml";

            ////AuthorsDataSet.ReadXml(filePath);

            ////dataGridView1.DataSource = AuthorsDataSet;
            ////dataGridView1.DataMember = "Folder";
            //xmlGridView.ViewMode = XmlGridView.VIEW_MODE.TABLE;
            //xmlGridView.DataSetTableIndex = 0;
            //xmlGridView.DataFilePath = "c:\\temp\SampleFile.xml";


            XmlTextReader reader = new XmlTextReader(@" C:\Users\Ana\Documents\Visual Studio 2013\Projects\windows forma za xml\windows forma za xml\FilesFromDrive.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        this.richTextBox1.SelectionColor = Color.Blue;
                        this.richTextBox1.AppendText("<");
                        this.richTextBox1.SelectionColor = Color.Brown;
                        this.richTextBox1.AppendText(reader.Name);
                        this.richTextBox1.SelectionColor = Color.Blue;
                        this.richTextBox1.AppendText(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        this.richTextBox1.SelectionColor = Color.Black;
                        this.richTextBox1.AppendText(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        this.richTextBox1.SelectionColor = Color.Blue;
                        this.richTextBox1.AppendText("</");
                        this.richTextBox1.SelectionColor = Color.Brown;
                        this.richTextBox1.AppendText(reader.Name);
                        this.richTextBox1.SelectionColor = Color.Blue;
                        this.richTextBox1.AppendText(">");
                        this.richTextBox1.AppendText("\n");
                        break;
                }
            }


        }

        private void ShowSchemaButton_Click(object sender, EventArgs e)
        {
            System.IO.StringWriter swXML = new System.IO.StringWriter();
            AuthorsDataSet.WriteXmlSchema(swXML);
            textBox1.Text = swXML.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }




            
    }
}
