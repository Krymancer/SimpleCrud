namespace SimpleCrud
{
    partial class Main
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.addbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.phonelabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.Size = new System.Drawing.Size(776, 302);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // addbutton
            // 
            this.addbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addbutton.Location = new System.Drawing.Point(657, 344);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(131, 23);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "Adicionar";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editbutton.Location = new System.Drawing.Point(657, 373);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(131, 23);
            this.editbutton.TabIndex = 2;
            this.editbutton.Text = "Editar";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebutton.Location = new System.Drawing.Point(657, 406);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(131, 23);
            this.deletebutton.TabIndex = 3;
            this.deletebutton.Text = "Deletar";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(9, 22);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(224, 20);
            this.nametextBox.TabIndex = 1;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(9, 66);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(224, 20);
            this.emailtextBox.TabIndex = 2;
            // 
            // phonetextBox
            // 
            this.phonetextBox.Location = new System.Drawing.Point(260, 66);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(224, 20);
            this.phonetextBox.TabIndex = 4;
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(260, 22);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(224, 20);
            this.addresstextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.phonelabel);
            this.panel1.Controls.Add(this.addresslabel);
            this.panel1.Controls.Add(this.emaillabel);
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Controls.Add(this.addresstextBox);
            this.panel1.Controls.Add(this.phonetextBox);
            this.panel1.Controls.Add(this.nametextBox);
            this.panel1.Controls.Add(this.emailtextBox);
            this.panel1.Location = new System.Drawing.Point(12, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 95);
            this.panel1.TabIndex = 8;
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Location = new System.Drawing.Point(257, 50);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(52, 13);
            this.phonelabel.TabIndex = 11;
            this.phonelabel.Text = "Telefone:";
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Location = new System.Drawing.Point(257, 6);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(56, 13);
            this.addresslabel.TabIndex = 10;
            this.addresslabel.Text = "Endereço:";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Location = new System.Drawing.Point(6, 50);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(35, 13);
            this.emaillabel.TabIndex = 9;
            this.emaillabel.Text = "Email:";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(6, 6);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(38, 13);
            this.namelabel.TabIndex = 8;
            this.namelabel.Text = "Nome:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.dataGridView);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox phonetextBox;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label namelabel;
    }
}