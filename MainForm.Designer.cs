
namespace propclip_grinding_tracker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCopySelect = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.dgvFilesIndicies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFilesMaps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFilesTicks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFilesLastModifiedDates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFilesFileNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butBrowseWorkDir = new System.Windows.Forms.Button();
            this.butBrowseGameDir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.boxWorkDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxGameDir = new System.Windows.Forms.TextBox();
            this.boxSaveDemoName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butHowTo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butCopySelect);
            this.groupBox1.Controls.Add(this.butClear);
            this.groupBox1.Controls.Add(this.dgvFiles);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Segments";
            // 
            // butCopySelect
            // 
            this.butCopySelect.Location = new System.Drawing.Point(601, 289);
            this.butCopySelect.Name = "butCopySelect";
            this.butCopySelect.Size = new System.Drawing.Size(88, 23);
            this.butCopySelect.TabIndex = 2;
            this.butCopySelect.Text = "Copy Selected";
            this.butCopySelect.UseVisualStyleBackColor = true;
            this.butCopySelect.Click += new System.EventHandler(this.butCopySelect_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(695, 289);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 1;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AllowUserToResizeRows = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFilesIndicies,
            this.dgvFilesMaps,
            this.dgvFilesTicks,
            this.dgvFilesLastModifiedDates,
            this.dgvFilesFileNames});
            this.dgvFiles.Location = new System.Drawing.Point(7, 19);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowHeadersVisible = false;
            this.dgvFiles.Size = new System.Drawing.Size(763, 264);
            this.dgvFiles.TabIndex = 0;
            // 
            // dgvFilesIndicies
            // 
            this.dgvFilesIndicies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvFilesIndicies.HeaderText = "Index";
            this.dgvFilesIndicies.Name = "dgvFilesIndicies";
            this.dgvFilesIndicies.ReadOnly = true;
            this.dgvFilesIndicies.Width = 58;
            // 
            // dgvFilesMaps
            // 
            this.dgvFilesMaps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvFilesMaps.HeaderText = "Map";
            this.dgvFilesMaps.MinimumWidth = 200;
            this.dgvFilesMaps.Name = "dgvFilesMaps";
            this.dgvFilesMaps.ReadOnly = true;
            this.dgvFilesMaps.Width = 200;
            // 
            // dgvFilesTicks
            // 
            this.dgvFilesTicks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvFilesTicks.HeaderText = "Ticks";
            this.dgvFilesTicks.Name = "dgvFilesTicks";
            this.dgvFilesTicks.ReadOnly = true;
            this.dgvFilesTicks.Width = 58;
            // 
            // dgvFilesLastModifiedDates
            // 
            this.dgvFilesLastModifiedDates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvFilesLastModifiedDates.HeaderText = "Last Modified Date";
            this.dgvFilesLastModifiedDates.MinimumWidth = 180;
            this.dgvFilesLastModifiedDates.Name = "dgvFilesLastModifiedDates";
            this.dgvFilesLastModifiedDates.ReadOnly = true;
            this.dgvFilesLastModifiedDates.Width = 180;
            // 
            // dgvFilesFileNames
            // 
            this.dgvFilesFileNames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvFilesFileNames.HeaderText = "File Name";
            this.dgvFilesFileNames.MinimumWidth = 200;
            this.dgvFilesFileNames.Name = "dgvFilesFileNames";
            this.dgvFilesFileNames.ReadOnly = true;
            this.dgvFilesFileNames.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butBrowseWorkDir);
            this.groupBox2.Controls.Add(this.butBrowseGameDir);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // butBrowseWorkDir
            // 
            this.butBrowseWorkDir.Location = new System.Drawing.Point(695, 46);
            this.butBrowseWorkDir.Name = "butBrowseWorkDir";
            this.butBrowseWorkDir.Size = new System.Drawing.Size(75, 23);
            this.butBrowseWorkDir.TabIndex = 2;
            this.butBrowseWorkDir.Text = "Browse";
            this.butBrowseWorkDir.UseVisualStyleBackColor = true;
            this.butBrowseWorkDir.Click += new System.EventHandler(this.butBrowseWorkDir_Click);
            // 
            // butBrowseGameDir
            // 
            this.butBrowseGameDir.Location = new System.Drawing.Point(695, 21);
            this.butBrowseGameDir.Name = "butBrowseGameDir";
            this.butBrowseGameDir.Size = new System.Drawing.Size(75, 23);
            this.butBrowseGameDir.TabIndex = 1;
            this.butBrowseGameDir.Text = "Browse";
            this.butBrowseGameDir.UseVisualStyleBackColor = true;
            this.butBrowseGameDir.Click += new System.EventHandler(this.butBrowseGameDir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.boxWorkDir, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.boxGameDir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.boxSaveDemoName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 75);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // boxWorkDir
            // 
            this.boxWorkDir.Location = new System.Drawing.Point(109, 28);
            this.boxWorkDir.Name = "boxWorkDir";
            this.boxWorkDir.Size = new System.Drawing.Size(570, 20);
            this.boxWorkDir.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Directory";
            // 
            // boxGameDir
            // 
            this.boxGameDir.Location = new System.Drawing.Point(109, 3);
            this.boxGameDir.Name = "boxGameDir";
            this.boxGameDir.Size = new System.Drawing.Size(570, 20);
            this.boxGameDir.TabIndex = 2;
            // 
            // boxSaveDemoName
            // 
            this.boxSaveDemoName.Location = new System.Drawing.Point(109, 53);
            this.boxSaveDemoName.Name = "boxSaveDemoName";
            this.boxSaveDemoName.Size = new System.Drawing.Size(290, 20);
            this.boxSaveDemoName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segment Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Working Directory";
            // 
            // butHowTo
            // 
            this.butHowTo.Location = new System.Drawing.Point(707, 444);
            this.butHowTo.Name = "butHowTo";
            this.butHowTo.Size = new System.Drawing.Size(81, 23);
            this.butHowTo.TabIndex = 2;
            this.butHowTo.Text = "How to Use?";
            this.butHowTo.UseVisualStyleBackColor = true;
            this.butHowTo.Click += new System.EventHandler(this.butHowTo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.butHowTo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Propclip Grinding Tracker";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butCopySelect;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butBrowseGameDir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox boxSaveDemoName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxGameDir;
        private System.Windows.Forms.Button butBrowseWorkDir;
        private System.Windows.Forms.TextBox boxWorkDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFilesIndicies;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFilesMaps;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFilesTicks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFilesLastModifiedDates;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFilesFileNames;
        private System.Windows.Forms.Button butHowTo;
    }
}

