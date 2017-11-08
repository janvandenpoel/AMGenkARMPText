namespace AMGenkARMPText
{
    partial class ARMPTextGenerator
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
            this.btnSORA = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnAandachtspunten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSORA
            // 
            this.btnSORA.Location = new System.Drawing.Point(13, 13);
            this.btnSORA.Name = "btnSORA";
            this.btnSORA.Size = new System.Drawing.Size(218, 23);
            this.btnSORA.TabIndex = 0;
            this.btnSORA.Text = "SORA";
            this.btnSORA.UseVisualStyleBackColor = true;
            this.btnSORA.Click += new System.EventHandler(this.btnSORA_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(13, 51);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(218, 23);
            this.btnS.TabIndex = 1;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(13, 92);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(218, 23);
            this.btnO.TabIndex = 2;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(13, 130);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(218, 23);
            this.btnR.TabIndex = 3;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(13, 168);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(218, 23);
            this.btnA.TabIndex = 4;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // button1
            // 
            this.btnAandachtspunten.Location = new System.Drawing.Point(13, 212);
            this.btnAandachtspunten.Name = "button1";
            this.btnAandachtspunten.Size = new System.Drawing.Size(218, 23);
            this.btnAandachtspunten.TabIndex = 5;
            this.btnAandachtspunten.Text = "Aandachtspunten";
            this.btnAandachtspunten.UseVisualStyleBackColor = true;
            this.btnAandachtspunten.Click += new System.EventHandler(this.btnAandachtspunten_Click);
            // 
            // ARMPTextGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 285);
            this.Controls.Add(this.btnAandachtspunten);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnSORA);
            this.Name = "ARMPTextGenerator";
            this.Text = "ARMP Text Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSORA;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnAandachtspunten;
    }
}

