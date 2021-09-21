
namespace Armor_DT_Classic_Converter
{
    partial class mainWindow
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
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.textboxNVDT = new System.Windows.Forms.TextBox();
            this.labelNVDT = new System.Windows.Forms.Label();
            this.outputClassicDR = new System.Windows.Forms.Label();
            this.labelClassicDR = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.outputClassicDT = new System.Windows.Forms.Label();
            this.labelClassicDT = new System.Windows.Forms.Label();
            this.radioButtonHeavy = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonLight = new System.Windows.Forms.RadioButton();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel1
            // 
            this.infoLabel1.Location = new System.Drawing.Point(11, 9);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(312, 59);
            this.infoLabel1.TabIndex = 0;
            this.infoLabel1.Text = "This program takes New Vega\'s DT values, and converts it to stats are are on par " +
    "with the Classic Fallout games.";
            this.infoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textboxNVDT
            // 
            this.textboxNVDT.Location = new System.Drawing.Point(223, 62);
            this.textboxNVDT.Name = "textboxNVDT";
            this.textboxNVDT.Size = new System.Drawing.Size(100, 20);
            this.textboxNVDT.TabIndex = 1;
            // 
            // labelNVDT
            // 
            this.labelNVDT.AutoSize = true;
            this.labelNVDT.Location = new System.Drawing.Point(107, 65);
            this.labelNVDT.Name = "labelNVDT";
            this.labelNVDT.Size = new System.Drawing.Size(110, 13);
            this.labelNVDT.TabIndex = 2;
            this.labelNVDT.Text = "New Vegas Armor DT";
            // 
            // outputClassicDR
            // 
            this.outputClassicDR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputClassicDR.Location = new System.Drawing.Point(223, 85);
            this.outputClassicDR.Name = "outputClassicDR";
            this.outputClassicDR.Size = new System.Drawing.Size(100, 20);
            this.outputClassicDR.TabIndex = 3;
            this.outputClassicDR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelClassicDR
            // 
            this.labelClassicDR.AutoSize = true;
            this.labelClassicDR.Location = new System.Drawing.Point(128, 89);
            this.labelClassicDR.Name = "labelClassicDR";
            this.labelClassicDR.Size = new System.Drawing.Size(89, 13);
            this.labelClassicDR.TabIndex = 4;
            this.labelClassicDR.Text = "Classic Armor DR";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(29, 136);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 5;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // outputClassicDT
            // 
            this.outputClassicDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputClassicDT.Location = new System.Drawing.Point(223, 109);
            this.outputClassicDT.Name = "outputClassicDT";
            this.outputClassicDT.Size = new System.Drawing.Size(100, 20);
            this.outputClassicDT.TabIndex = 6;
            this.outputClassicDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelClassicDT
            // 
            this.labelClassicDT.AutoSize = true;
            this.labelClassicDT.Location = new System.Drawing.Point(137, 113);
            this.labelClassicDT.Name = "labelClassicDT";
            this.labelClassicDT.Size = new System.Drawing.Size(80, 13);
            this.labelClassicDT.TabIndex = 7;
            this.labelClassicDT.Text = "Class Armor DT";
            // 
            // radioButtonHeavy
            // 
            this.radioButtonHeavy.AutoSize = true;
            this.radioButtonHeavy.Location = new System.Drawing.Point(12, 64);
            this.radioButtonHeavy.Name = "radioButtonHeavy";
            this.radioButtonHeavy.Size = new System.Drawing.Size(86, 17);
            this.radioButtonHeavy.TabIndex = 8;
            this.radioButtonHeavy.TabStop = true;
            this.radioButtonHeavy.Text = "Heavy Armor";
            this.radioButtonHeavy.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(12, 87);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(92, 17);
            this.radioButtonMedium.TabIndex = 9;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium Armor";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonLight
            // 
            this.radioButtonLight.AutoSize = true;
            this.radioButtonLight.Location = new System.Drawing.Point(12, 110);
            this.radioButtonLight.Name = "radioButtonLight";
            this.radioButtonLight.Size = new System.Drawing.Size(78, 17);
            this.radioButtonLight.TabIndex = 10;
            this.radioButtonLight.TabStop = true;
            this.radioButtonLight.Text = "Light Armor";
            this.radioButtonLight.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(110, 136);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 171);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.radioButtonLight);
            this.Controls.Add(this.radioButtonMedium);
            this.Controls.Add(this.radioButtonHeavy);
            this.Controls.Add(this.labelClassicDT);
            this.Controls.Add(this.outputClassicDT);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelClassicDR);
            this.Controls.Add(this.outputClassicDR);
            this.Controls.Add(this.labelNVDT);
            this.Controls.Add(this.textboxNVDT);
            this.Controls.Add(this.infoLabel1);
            this.Name = "mainWindow";
            this.Text = "Armor Stat Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.TextBox textboxNVDT;
        private System.Windows.Forms.Label labelNVDT;
        private System.Windows.Forms.Label outputClassicDR;
        private System.Windows.Forms.Label labelClassicDR;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label outputClassicDT;
        private System.Windows.Forms.Label labelClassicDT;
        private System.Windows.Forms.RadioButton radioButtonHeavy;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonLight;
        private System.Windows.Forms.Button buttonClear;
    }
}

