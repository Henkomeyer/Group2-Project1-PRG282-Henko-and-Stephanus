namespace Group2_Project_MainProgram
{
    partial class ModuleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxResourceLinks = new System.Windows.Forms.TextBox();
            this.tbxModuleDescription = new System.Windows.Forms.TextBox();
            this.tbxModuleName = new System.Windows.Forms.TextBox();
            this.tbxModuleCode = new System.Windows.Forms.TextBox();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.btnUpdateModule = new System.Windows.Forms.Button();
            this.btnDeleteModule = new System.Windows.Forms.Button();
            this.btnSearchModule = new System.Windows.Forms.Button();
            this.btnBackModule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxSearchModule = new System.Windows.Forms.TextBox();
            this.btnDisplayModules = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resource Links:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Module Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxResourceLinks);
            this.groupBox1.Controls.Add(this.tbxModuleDescription);
            this.groupBox1.Controls.Add(this.tbxModuleName);
            this.groupBox1.Controls.Add(this.tbxModuleCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(17, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(280, 263);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module Information";
            // 
            // tbxResourceLinks
            // 
            this.tbxResourceLinks.Location = new System.Drawing.Point(116, 194);
            this.tbxResourceLinks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxResourceLinks.Name = "tbxResourceLinks";
            this.tbxResourceLinks.Size = new System.Drawing.Size(132, 20);
            this.tbxResourceLinks.TabIndex = 14;
            // 
            // tbxModuleDescription
            // 
            this.tbxModuleDescription.Location = new System.Drawing.Point(116, 154);
            this.tbxModuleDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxModuleDescription.Name = "tbxModuleDescription";
            this.tbxModuleDescription.Size = new System.Drawing.Size(132, 20);
            this.tbxModuleDescription.TabIndex = 13;
            // 
            // tbxModuleName
            // 
            this.tbxModuleName.Location = new System.Drawing.Point(116, 108);
            this.tbxModuleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxModuleName.Name = "tbxModuleName";
            this.tbxModuleName.Size = new System.Drawing.Size(132, 20);
            this.tbxModuleName.TabIndex = 12;
            // 
            // tbxModuleCode
            // 
            this.tbxModuleCode.Location = new System.Drawing.Point(116, 67);
            this.tbxModuleCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxModuleCode.Name = "tbxModuleCode";
            this.tbxModuleCode.Size = new System.Drawing.Size(132, 20);
            this.tbxModuleCode.TabIndex = 11;
            // 
            // btnAddModule
            // 
            this.btnAddModule.Location = new System.Drawing.Point(16, 393);
            this.btnAddModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(99, 49);
            this.btnAddModule.TabIndex = 5;
            this.btnAddModule.Text = "Add Module";
            this.btnAddModule.UseVisualStyleBackColor = true;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // btnUpdateModule
            // 
            this.btnUpdateModule.Location = new System.Drawing.Point(164, 393);
            this.btnUpdateModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateModule.Name = "btnUpdateModule";
            this.btnUpdateModule.Size = new System.Drawing.Size(99, 49);
            this.btnUpdateModule.TabIndex = 6;
            this.btnUpdateModule.Text = "Update Information";
            this.btnUpdateModule.UseVisualStyleBackColor = true;
            this.btnUpdateModule.Click += new System.EventHandler(this.btnUpdateModule_Click);
            // 
            // btnDeleteModule
            // 
            this.btnDeleteModule.Location = new System.Drawing.Point(306, 393);
            this.btnDeleteModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteModule.Name = "btnDeleteModule";
            this.btnDeleteModule.Size = new System.Drawing.Size(99, 49);
            this.btnDeleteModule.TabIndex = 7;
            this.btnDeleteModule.Text = "Delete Module";
            this.btnDeleteModule.UseVisualStyleBackColor = true;
            this.btnDeleteModule.Click += new System.EventHandler(this.btnDeleteModule_Click);
            // 
            // btnSearchModule
            // 
            this.btnSearchModule.Location = new System.Drawing.Point(444, 31);
            this.btnSearchModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchModule.Name = "btnSearchModule";
            this.btnSearchModule.Size = new System.Drawing.Size(106, 26);
            this.btnSearchModule.TabIndex = 8;
            this.btnSearchModule.Text = "Search Module Code";
            this.btnSearchModule.UseVisualStyleBackColor = true;
            this.btnSearchModule.Click += new System.EventHandler(this.btnSearchModule_Click);
            // 
            // btnBackModule
            // 
            this.btnBackModule.Location = new System.Drawing.Point(718, 393);
            this.btnBackModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackModule.Name = "btnBackModule";
            this.btnBackModule.Size = new System.Drawing.Size(57, 49);
            this.btnBackModule.TabIndex = 9;
            this.btnBackModule.Text = "Back";
            this.btnBackModule.UseVisualStyleBackColor = true;
            this.btnBackModule.Click += new System.EventHandler(this.btnBackModule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(449, 291);
            this.dataGridView1.TabIndex = 10;
            // 
            // tbxSearchModule
            // 
            this.tbxSearchModule.Location = new System.Drawing.Point(554, 31);
            this.tbxSearchModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSearchModule.Name = "tbxSearchModule";
            this.tbxSearchModule.Size = new System.Drawing.Size(125, 20);
            this.tbxSearchModule.TabIndex = 15;
            // 
            // btnDisplayModules
            // 
            this.btnDisplayModules.Location = new System.Drawing.Point(511, 393);
            this.btnDisplayModules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisplayModules.Name = "btnDisplayModules";
            this.btnDisplayModules.Size = new System.Drawing.Size(99, 49);
            this.btnDisplayModules.TabIndex = 16;
            this.btnDisplayModules.Text = "Display Modules";
            this.btnDisplayModules.UseVisualStyleBackColor = true;
            this.btnDisplayModules.Click += new System.EventHandler(this.btnDisplayModules_Click);
            // 
            // ModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 487);
            this.Controls.Add(this.btnDisplayModules);
            this.Controls.Add(this.tbxSearchModule);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBackModule);
            this.Controls.Add(this.btnSearchModule);
            this.Controls.Add(this.btnDeleteModule);
            this.Controls.Add(this.btnUpdateModule);
            this.Controls.Add(this.btnAddModule);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModuleForm";
            this.Text = "ModuleForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.Button btnUpdateModule;
        private System.Windows.Forms.Button btnDeleteModule;
        private System.Windows.Forms.Button btnSearchModule;
        private System.Windows.Forms.Button btnBackModule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxResourceLinks;
        private System.Windows.Forms.TextBox tbxModuleDescription;
        private System.Windows.Forms.TextBox tbxModuleName;
        private System.Windows.Forms.TextBox tbxModuleCode;
        private System.Windows.Forms.TextBox tbxSearchModule;
        private System.Windows.Forms.Button btnDisplayModules;
    }
}