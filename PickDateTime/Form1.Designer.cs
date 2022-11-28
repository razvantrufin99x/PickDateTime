namespace PickDateTime
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pickerDateTime1 = new PickDateTime.pickerDateTime();
            this.SuspendLayout();
            // 
            // pickerDateTime1
            // 
            this.pickerDateTime1.Location = new System.Drawing.Point(25, 104);
            this.pickerDateTime1.Name = "pickerDateTime1";
            this.pickerDateTime1.Size = new System.Drawing.Size(1599, 169);
            this.pickerDateTime1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 503);
            this.Controls.Add(this.pickerDateTime1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private pickerDateTime pickerDateTime1;
    }
}