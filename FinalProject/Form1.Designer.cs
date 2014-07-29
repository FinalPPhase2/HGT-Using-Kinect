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
            this.buttonRecord = new System.Windows.Forms.Button();
            this.groupBoxRecordMode = new System.Windows.Forms.GroupBox();
            this.buttonTestMode = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxRecordMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRecord
            // 
            this.buttonRecord.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRecord.Location = new System.Drawing.Point(84, 221);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(63, 63);
            this.buttonRecord.TabIndex = 0;
            this.buttonRecord.UseVisualStyleBackColor = true;
            // 
            // groupBoxRecordMode
            // 
            this.groupBoxRecordMode.Controls.Add(this.button2);
            this.groupBoxRecordMode.Controls.Add(this.buttonTestMode);
            this.groupBoxRecordMode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxRecordMode.Location = new System.Drawing.Point(69, 63);
            this.groupBoxRecordMode.Name = "groupBoxRecordMode";
            this.groupBoxRecordMode.Size = new System.Drawing.Size(100, 104);
            this.groupBoxRecordMode.TabIndex = 1;
            this.groupBoxRecordMode.TabStop = false;
            this.groupBoxRecordMode.Text = "Record mode";
            // 
            // buttonTestMode
            // 
            this.buttonTestMode.Location = new System.Drawing.Point(15, 19);
            this.buttonTestMode.Name = "buttonTestMode";
            this.buttonTestMode.Size = new System.Drawing.Size(75, 23);
            this.buttonTestMode.TabIndex = 0;
            this.buttonTestMode.Text = "Test";
            this.buttonTestMode.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(749, 417);
            this.Controls.Add(this.groupBoxRecordMode);
            this.Controls.Add(this.buttonRecord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxRecordMode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.GroupBox groupBoxRecordMode;
        private System.Windows.Forms.Button buttonTestMode;
        private System.Windows.Forms.Button button2;


    }
}

