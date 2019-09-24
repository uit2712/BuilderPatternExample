namespace ChangeClothes
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
            this.pnlCharacter = new System.Windows.Forms.Panel();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.cbbCharacter = new System.Windows.Forms.ComboBox();
            this.lblClothes = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pnlCharacter
            // 
            this.pnlCharacter.BackColor = System.Drawing.Color.White;
            this.pnlCharacter.Location = new System.Drawing.Point(12, 12);
            this.pnlCharacter.Name = "pnlCharacter";
            this.pnlCharacter.Size = new System.Drawing.Size(428, 563);
            this.pnlCharacter.TabIndex = 0;
            this.pnlCharacter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCharacter_Paint);
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Location = new System.Drawing.Point(446, 23);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(51, 13);
            this.lblCharacter.TabIndex = 1;
            this.lblCharacter.Text = "Nhân vật";
            // 
            // cbbCharacter
            // 
            this.cbbCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCharacter.FormattingEnabled = true;
            this.cbbCharacter.Items.AddRange(new object[] {
            "Doraemon",
            "Nobita"});
            this.cbbCharacter.Location = new System.Drawing.Point(506, 20);
            this.cbbCharacter.Name = "cbbCharacter";
            this.cbbCharacter.Size = new System.Drawing.Size(121, 21);
            this.cbbCharacter.TabIndex = 2;
            this.cbbCharacter.SelectedIndexChanged += new System.EventHandler(this.cbbCharacter_SelectedIndexChanged);
            // 
            // lblClothes
            // 
            this.lblClothes.AutoSize = true;
            this.lblClothes.Location = new System.Drawing.Point(446, 50);
            this.lblClothes.Name = "lblClothes";
            this.lblClothes.Size = new System.Drawing.Size(48, 13);
            this.lblClothes.TabIndex = 1;
            this.lblClothes.Text = "Quần áo";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cô nàng quyến rũ"});
            this.comboBox1.Location = new System.Drawing.Point(506, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.cbbCharacter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 587);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblClothes);
            this.Controls.Add(this.cbbCharacter);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.pnlCharacter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCharacter;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.ComboBox cbbCharacter;
        private System.Windows.Forms.Label lblClothes;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

