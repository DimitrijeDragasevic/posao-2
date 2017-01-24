namespace windows_forma_za_xml
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadxmlButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShowSchemaButton = new System.Windows.Forms.Button();
            this.AuthorsDataSet = new System.Data.DataSet();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadxmlButton
            // 
            this.ReadxmlButton.Location = new System.Drawing.Point(344, 314);
            this.ReadxmlButton.Name = "ReadxmlButton";
            this.ReadxmlButton.Size = new System.Drawing.Size(87, 25);
            this.ReadxmlButton.TabIndex = 1;
            this.ReadxmlButton.Text = "Read Xml";
            this.ReadxmlButton.UseVisualStyleBackColor = true;
            this.ReadxmlButton.Click += new System.EventHandler(this.ReadxmlButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 350);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(126, 148);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ShowSchemaButton
            // 
            this.ShowSchemaButton.Location = new System.Drawing.Point(468, 316);
            this.ShowSchemaButton.Name = "ShowSchemaButton";
            this.ShowSchemaButton.Size = new System.Drawing.Size(109, 23);
            this.ShowSchemaButton.TabIndex = 4;
            this.ShowSchemaButton.Text = "Show Schema";
            this.ShowSchemaButton.UseVisualStyleBackColor = true;
            this.ShowSchemaButton.Click += new System.EventHandler(this.ShowSchemaButton_Click);
            // 
            // AuthorsDataSet
            // 
            this.AuthorsDataSet.DataSetName = "AuthorsDataSet";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(334, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(160, 177);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 374);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ShowSchemaButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReadxmlButton);
            this.Name = "Form1";
            this.Text = "Xml Drive Tree";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadxmlButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ShowSchemaButton;
        private System.Data.DataSet AuthorsDataSet;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

