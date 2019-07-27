namespace justFeast
{
    partial class convertAssistant
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
            this.convertGrBox = new System.Windows.Forms.GroupBox();
            this.ConvertLabel = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.weightLabel = new System.Windows.Forms.Label();
            this.inputWeight = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.comboFromUnit = new System.Windows.Forms.ComboBox();
            this.comboToUnit = new System.Windows.Forms.ComboBox();
            this.outputUnitRes = new System.Windows.Forms.TextBox();
            this.convertGrBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertGrBox
            // 
            this.convertGrBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.convertGrBox.Controls.Add(this.ConvertLabel);
            this.convertGrBox.Font = new System.Drawing.Font("Broadway", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.convertGrBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.convertGrBox.Location = new System.Drawing.Point(95, 2);
            this.convertGrBox.Name = "convertGrBox";
            this.convertGrBox.Size = new System.Drawing.Size(277, 54);
            this.convertGrBox.TabIndex = 4;
            this.convertGrBox.TabStop = false;
            this.convertGrBox.Text = "JUST FEAST";
            // 
            // ConvertLabel
            // 
            this.ConvertLabel.AutoSize = true;
            this.ConvertLabel.Font = new System.Drawing.Font("Broadway", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ConvertLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ConvertLabel.Location = new System.Drawing.Point(6, 17);
            this.ConvertLabel.Name = "ConvertLabel";
            this.ConvertLabel.Size = new System.Drawing.Size(255, 27);
            this.ConvertLabel.TabIndex = 2;
            this.ConvertLabel.Text = "Convert Assistant";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Crimson;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnConvert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConvert.Location = new System.Drawing.Point(259, 141);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(97, 30);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.weightLabel.ForeColor = System.Drawing.Color.Crimson;
            this.weightLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.weightLabel.Location = new System.Drawing.Point(12, 120);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(192, 18);
            this.weightLabel.TabIndex = 13;
            this.weightLabel.Text = "Enter Unit to Convert . . ";
            // 
            // inputWeight
            // 
            this.inputWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputWeight.Location = new System.Drawing.Point(12, 141);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(211, 31);
            this.inputWeight.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(390, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 77);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.fromLabel.ForeColor = System.Drawing.Color.Crimson;
            this.fromLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fromLabel.Location = new System.Drawing.Point(65, 66);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(92, 18);
            this.fromLabel.TabIndex = 17;
            this.fromLabel.Text = "From Units";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.toLabel.ForeColor = System.Drawing.Color.Crimson;
            this.toLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toLabel.Location = new System.Drawing.Point(295, 66);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(72, 18);
            this.toLabel.TabIndex = 18;
            this.toLabel.Text = "To Units";
            // 
            // comboFromUnit
            // 
            this.comboFromUnit.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.comboFromUnit.FormattingEnabled = true;
            this.comboFromUnit.Location = new System.Drawing.Point(12, 87);
            this.comboFromUnit.Name = "comboFromUnit";
            this.comboFromUnit.Size = new System.Drawing.Size(199, 27);
            this.comboFromUnit.TabIndex = 19;
            // 
            // comboToUnit
            // 
            this.comboToUnit.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.comboToUnit.FormattingEnabled = true;
            this.comboToUnit.Location = new System.Drawing.Point(239, 87);
            this.comboToUnit.Name = "comboToUnit";
            this.comboToUnit.Size = new System.Drawing.Size(199, 27);
            this.comboToUnit.TabIndex = 19;
            // 
            // outputUnitRes
            // 
            this.outputUnitRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputUnitRes.Location = new System.Drawing.Point(64, 179);
            this.outputUnitRes.Name = "outputUnitRes";
            this.outputUnitRes.Size = new System.Drawing.Size(292, 31);
            this.outputUnitRes.TabIndex = 20;
            // 
            // convertAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(502, 222);
            this.Controls.Add(this.outputUnitRes);
            this.Controls.Add(this.comboToUnit);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.comboFromUnit);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.inputWeight);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.convertGrBox);
            this.Name = "convertAssistant";
            this.Text = "convertAssistant";
            this.Load += new System.EventHandler(this.convertAssistant_Load);
            this.convertGrBox.ResumeLayout(false);
            this.convertGrBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox convertGrBox;
        private System.Windows.Forms.Label ConvertLabel;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox inputWeight;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.ComboBox comboFromUnit;
        private System.Windows.Forms.ComboBox comboToUnit;
        private System.Windows.Forms.TextBox outputUnitRes;
    }
}