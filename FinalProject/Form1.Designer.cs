namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used. testing commit Ofer brunch
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
            this.groupBoxRecordMode = new System.Windows.Forms.GroupBox();
            this.buttonTraining = new System.Windows.Forms.Button();
            this.buttonRec = new System.Windows.Forms.Button();
            this.buttonTestMode = new System.Windows.Forms.Button();
            this.groupBoxRecordMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRecordMode
            // 
            this.groupBoxRecordMode.Controls.Add(this.buttonTraining);
            this.groupBoxRecordMode.Controls.Add(this.buttonTestMode);
            this.groupBoxRecordMode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxRecordMode.Location = new System.Drawing.Point(69, 20);
            this.groupBoxRecordMode.Name = "groupBoxRecordMode";
            this.groupBoxRecordMode.Size = new System.Drawing.Size(96, 161);
            this.groupBoxRecordMode.TabIndex = 1;
            this.groupBoxRecordMode.TabStop = false;
            this.groupBoxRecordMode.Text = "Record mode";
            // 
            // buttonTraining
            // 
            this.buttonTraining.Location = new System.Drawing.Point(15, 92);
            this.buttonTraining.Name = "buttonTraining";
            this.buttonTraining.Size = new System.Drawing.Size(63, 63);
            this.buttonTraining.TabIndex = 1;
            this.buttonTraining.Text = "Training";
            this.buttonTraining.UseVisualStyleBackColor = true;
            // 
            // buttonRec
            // 
            this.buttonRec.Image = global::FinalProject.Properties.Resources.recButton1;
            this.buttonRec.Location = new System.Drawing.Point(84, 209);
            this.buttonRec.Name = "buttonRec";
            this.buttonRec.Size = new System.Drawing.Size(63, 63);
            this.buttonRec.TabIndex = 2;
            this.buttonRec.UseVisualStyleBackColor = true;
            // 
            // buttonTestMode
            // 
            this.buttonTestMode.Image = global::FinalProject.Properties.Resources.test;
            this.buttonTestMode.Location = new System.Drawing.Point(15, 19);
            this.buttonTestMode.Name = "buttonTestMode";
            this.buttonTestMode.Size = new System.Drawing.Size(63, 63);
            this.buttonTestMode.TabIndex = 0;
            this.buttonTestMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(749, 417);
            this.Controls.Add(this.buttonRec);
            this.Controls.Add(this.groupBoxRecordMode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxRecordMode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRecordMode;
        private System.Windows.Forms.Button buttonTestMode;
        private System.Windows.Forms.Button buttonTraining;
        private System.Windows.Forms.Button buttonRec;


    }
}

