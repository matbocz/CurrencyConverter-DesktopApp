namespace CurrencyConverterApp
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.pictureBoxFrom = new System.Windows.Forms.PictureBox();
            this.pictureBoxTo = new System.Windows.Forms.PictureBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.numericUpDownFrom = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(55, 61);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(270, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Currency Converter";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "PLN",
            "EUR",
            "USD",
            "CHF",
            "GBP"});
            this.comboBoxFrom.Location = new System.Drawing.Point(12, 160);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(165, 24);
            this.comboBoxFrom.TabIndex = 1;
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrom_SelectedIndexChanged);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "PLN",
            "EUR",
            "USD",
            "CHF",
            "GBP"});
            this.comboBoxTo.Location = new System.Drawing.Point(224, 160);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(165, 24);
            this.comboBoxTo.TabIndex = 2;
            this.comboBoxTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTo_SelectedIndexChanged);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(12, 140);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(44, 17);
            this.labelFrom.TabIndex = 3;
            this.labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(221, 140);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(29, 17);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "To:";
            // 
            // pictureBoxFrom
            // 
            this.pictureBoxFrom.Location = new System.Drawing.Point(12, 190);
            this.pictureBoxFrom.Name = "pictureBoxFrom";
            this.pictureBoxFrom.Size = new System.Drawing.Size(165, 121);
            this.pictureBoxFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFrom.TabIndex = 5;
            this.pictureBoxFrom.TabStop = false;
            // 
            // pictureBoxTo
            // 
            this.pictureBoxTo.Location = new System.Drawing.Point(224, 190);
            this.pictureBoxTo.Name = "pictureBoxTo";
            this.pictureBoxTo.Size = new System.Drawing.Size(165, 121);
            this.pictureBoxTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTo.TabIndex = 6;
            this.pictureBoxTo.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.Control;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelResult.Location = new System.Drawing.Point(224, 320);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(18, 19);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "1";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(268, 363);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(121, 23);
            this.buttonConvert.TabIndex = 8;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // numericUpDownFrom
            // 
            this.numericUpDownFrom.Location = new System.Drawing.Point(12, 317);
            this.numericUpDownFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFrom.Name = "numericUpDownFrom";
            this.numericUpDownFrom.Size = new System.Drawing.Size(165, 22);
            this.numericUpDownFrom.TabIndex = 9;
            this.numericUpDownFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(12, 363);
            this.dateTimePickerFrom.MinDate = new System.DateTime(1999, 2, 1, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(165, 22);
            this.dateTimePickerFrom.TabIndex = 10;
            this.dateTimePickerFrom.Value = new System.DateTime(2020, 1, 22, 16, 52, 34, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 398);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.numericUpDownFrom);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.pictureBoxTo);
            this.Controls.Add(this.pictureBoxFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.PictureBox pictureBoxFrom;
        private System.Windows.Forms.PictureBox pictureBoxTo;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.NumericUpDown numericUpDownFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
    }
}

