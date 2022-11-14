namespace Group2_Project_MainProgram
{
    partial class CRUDOperationForm
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
            this.btnstudents = new System.Windows.Forms.Button();
            this.btnaddmodule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstudents
            // 
            this.btnstudents.Location = new System.Drawing.Point(214, 183);
            this.btnstudents.Name = "btnstudents";
            this.btnstudents.Size = new System.Drawing.Size(205, 133);
            this.btnstudents.TabIndex = 0;
            this.btnstudents.Text = "Students";
            this.btnstudents.UseVisualStyleBackColor = true;
            this.btnstudents.Click += new System.EventHandler(this.btnstudents_Click);
            // 
            // btnaddmodule
            // 
            this.btnaddmodule.Location = new System.Drawing.Point(547, 183);
            this.btnaddmodule.Name = "btnaddmodule";
            this.btnaddmodule.Size = new System.Drawing.Size(205, 133);
            this.btnaddmodule.TabIndex = 1;
            this.btnaddmodule.Text = "Modules";
            this.btnaddmodule.UseVisualStyleBackColor = true;
            this.btnaddmodule.Click += new System.EventHandler(this.btnaddmodule_Click);
            // 
            // CRUDOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnaddmodule);
            this.Controls.Add(this.btnstudents);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CRUDOperationForm";
            this.Text = "Landing Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstudents;
        private System.Windows.Forms.Button btnaddmodule;
    }
}

