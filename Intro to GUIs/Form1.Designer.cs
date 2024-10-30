namespace Intro_to_GUIs
{
    partial class MainForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.imgCharacter = new System.Windows.Forms.PictureBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(186, 95);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Click Me";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // imgCharacter
            // 
            this.imgCharacter.Location = new System.Drawing.Point(482, 51);
            this.imgCharacter.Name = "imgCharacter";
            this.imgCharacter.Size = new System.Drawing.Size(100, 50);
            this.imgCharacter.TabIndex = 1;
            this.imgCharacter.TabStop = false;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(207, 157);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(180, 13);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Click on the Button or the Picturebox";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(206, 245);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(180, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Click on the Button or the Picturebox";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.imgCharacter);
            this.Controls.Add(this.btnSubmit);
            this.Name = "MainForm";
            this.Text = "Controls, Events and Properties ";
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox imgCharacter;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblStatus;
    }
}

