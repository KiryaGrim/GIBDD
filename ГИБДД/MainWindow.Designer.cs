namespace ГИБДД
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.CreateDriver = new System.Windows.Forms.Button();
            this.ReloadTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // CreateDriver
            // 
            this.CreateDriver.Location = new System.Drawing.Point(43, 26);
            this.CreateDriver.Name = "CreateDriver";
            this.CreateDriver.Size = new System.Drawing.Size(109, 32);
            this.CreateDriver.TabIndex = 0;
            this.CreateDriver.Text = "Создать";
            this.CreateDriver.UseVisualStyleBackColor = true;
            this.CreateDriver.Click += new System.EventHandler(this.CreateDriver_Click);
            // 
            // ReloadTable
            // 
            this.ReloadTable.Location = new System.Drawing.Point(188, 26);
            this.ReloadTable.Name = "ReloadTable";
            this.ReloadTable.Size = new System.Drawing.Size(139, 32);
            this.ReloadTable.TabIndex = 1;
            this.ReloadTable.Text = "Перезагрузить";
            this.ReloadTable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(425, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Водители";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(43, 115);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(974, 407);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReloadTable);
            this.Controls.Add(this.CreateDriver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateDriver;
        private System.Windows.Forms.Button ReloadTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}