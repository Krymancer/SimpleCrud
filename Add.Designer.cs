namespace SimpleCrud
{
    partial class Add
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
            this.namelabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.addresslabel = new System.Windows.Forms.Label();
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.phonelabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(26, 30);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(38, 13);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Nome:";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(29, 46);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(198, 20);
            this.nametextBox.TabIndex = 1;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(29, 94);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(198, 20);
            this.emailtextBox.TabIndex = 3;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Location = new System.Drawing.Point(26, 78);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(35, 13);
            this.emaillabel.TabIndex = 2;
            this.emaillabel.Text = "Email:";
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(29, 146);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(198, 20);
            this.addresstextBox.TabIndex = 5;
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Location = new System.Drawing.Point(26, 130);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(56, 13);
            this.addresslabel.TabIndex = 4;
            this.addresslabel.Text = "Endereço:";
            // 
            // phonetextBox
            // 
            this.phonetextBox.Location = new System.Drawing.Point(29, 197);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(198, 20);
            this.phonetextBox.TabIndex = 7;
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Location = new System.Drawing.Point(26, 181);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(52, 13);
            this.phonelabel.TabIndex = 6;
            this.phonelabel.Text = "Telefone:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(21, 245);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Adicionar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(127, 245);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Add
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 293);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.phonetextBox);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.namelabel);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.TextBox phonetextBox;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}