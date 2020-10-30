namespace RegisztracioAlkalmazas
{
    partial class regAlk
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
            System.Windows.Forms.Label label6;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hobbikList = new System.Windows.Forms.ListBox();
            this.nevText = new System.Windows.Forms.TextBox();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioN = new System.Windows.Forms.RadioButton();
            this.dateSzül = new System.Windows.Forms.DateTimePicker();
            this.ujText = new System.Windows.Forms.TextBox();
            this.huzzaadButton = new System.Windows.Forms.Button();
            this.betoltesButton = new System.Windows.Forms.Button();
            this.mentesButton = new System.Windows.Forms.Button();
            this.nemePanel = new System.Windows.Forms.Panel();
            this.mentes = new System.Windows.Forms.SaveFileDialog();
            this.megnyitas = new System.Windows.Forms.OpenFileDialog();
            label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szül. dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nem:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label6.Location = new System.Drawing.Point(214, 153);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 20);
            label6.TabIndex = 5;
            label6.Text = "Új hobbi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(268, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kedvenc hobbi:";
            // 
            // hobbikList
            // 
            this.hobbikList.FormattingEnabled = true;
            this.hobbikList.Items.AddRange(new object[] {
            "Uszás",
            "Horgászat",
            "Futás"});
            this.hobbikList.Location = new System.Drawing.Point(306, 32);
            this.hobbikList.Name = "hobbikList";
            this.hobbikList.Size = new System.Drawing.Size(120, 95);
            this.hobbikList.TabIndex = 7;
            this.hobbikList.SelectedIndexChanged += new System.EventHandler(this.hobbikList_SelectedIndexChanged);
            // 
            // nevText
            // 
            this.nevText.Location = new System.Drawing.Point(115, 6);
            this.nevText.Name = "nevText";
            this.nevText.Size = new System.Drawing.Size(131, 20);
            this.nevText.TabIndex = 9;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(175, 79);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(31, 17);
            this.radioF.TabIndex = 12;
            this.radioF.TabStop = true;
            this.radioF.Text = "F";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioN
            // 
            this.radioN.AutoSize = true;
            this.radioN.Location = new System.Drawing.Point(115, 79);
            this.radioN.Name = "radioN";
            this.radioN.Size = new System.Drawing.Size(33, 17);
            this.radioN.TabIndex = 13;
            this.radioN.TabStop = true;
            this.radioN.Text = "N";
            this.radioN.UseVisualStyleBackColor = true;
            // 
            // dateSzül
            // 
            this.dateSzül.Location = new System.Drawing.Point(115, 42);
            this.dateSzül.Name = "dateSzül";
            this.dateSzül.Size = new System.Drawing.Size(131, 20);
            this.dateSzül.TabIndex = 14;
            // 
            // ujText
            // 
            this.ujText.Location = new System.Drawing.Point(306, 153);
            this.ujText.Name = "ujText";
            this.ujText.Size = new System.Drawing.Size(120, 20);
            this.ujText.TabIndex = 15;
            this.ujText.TextChanged += new System.EventHandler(this.ujText_TextChanged);
            // 
            // huzzaadButton
            // 
            this.huzzaadButton.Location = new System.Drawing.Point(351, 179);
            this.huzzaadButton.Name = "huzzaadButton";
            this.huzzaadButton.Size = new System.Drawing.Size(75, 23);
            this.huzzaadButton.TabIndex = 16;
            this.huzzaadButton.Text = "Hozzáad";
            this.huzzaadButton.UseVisualStyleBackColor = true;
            this.huzzaadButton.Click += new System.EventHandler(this.huzzaadButton_Click);
            // 
            // betoltesButton
            // 
            this.betoltesButton.Location = new System.Drawing.Point(354, 214);
            this.betoltesButton.Name = "betoltesButton";
            this.betoltesButton.Size = new System.Drawing.Size(75, 23);
            this.betoltesButton.TabIndex = 17;
            this.betoltesButton.Text = "Betöltés";
            this.betoltesButton.UseVisualStyleBackColor = true;
            this.betoltesButton.Click += new System.EventHandler(this.betoltesButton_Click);
            // 
            // mentesButton
            // 
            this.mentesButton.Location = new System.Drawing.Point(260, 214);
            this.mentesButton.Name = "mentesButton";
            this.mentesButton.Size = new System.Drawing.Size(75, 23);
            this.mentesButton.TabIndex = 18;
            this.mentesButton.Text = "Mentés";
            this.mentesButton.UseVisualStyleBackColor = true;
            this.mentesButton.Click += new System.EventHandler(this.mentesButton_Click);
            // 
            // nemePanel
            // 
            this.nemePanel.Location = new System.Drawing.Point(106, 68);
            this.nemePanel.Name = "nemePanel";
            this.nemePanel.Size = new System.Drawing.Size(109, 48);
            this.nemePanel.TabIndex = 19;
            // 
            // mentes
            // 
            this.mentes.FileOk += new System.ComponentModel.CancelEventHandler(this.mentes_FileOk);
            // 
            // megnyitas
            // 
            this.megnyitas.FileName = "megnyitas";
            // 
            // regAlk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(441, 293);
            this.Controls.Add(this.mentesButton);
            this.Controls.Add(this.betoltesButton);
            this.Controls.Add(this.huzzaadButton);
            this.Controls.Add(this.ujText);
            this.Controls.Add(this.dateSzül);
            this.Controls.Add(this.radioN);
            this.Controls.Add(this.radioF);
            this.Controls.Add(this.nevText);
            this.Controls.Add(this.hobbikList);
            this.Controls.Add(this.label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nemePanel);
            this.Name = "regAlk";
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox hobbikList;
        private System.Windows.Forms.TextBox nevText;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioN;
        private System.Windows.Forms.DateTimePicker dateSzül;
        private System.Windows.Forms.TextBox ujText;
        private System.Windows.Forms.Button huzzaadButton;
        private System.Windows.Forms.Button betoltesButton;
        private System.Windows.Forms.Button mentesButton;
        private System.Windows.Forms.Panel nemePanel;
        private System.Windows.Forms.SaveFileDialog mentes;
        private System.Windows.Forms.OpenFileDialog megnyitas;
    }
}

