namespace mp2021
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
            this.components = new System.ComponentModel.Container();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.delAllButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.minuteBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(696, 169);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(696, 225);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 23);
            this.delButton.TabIndex = 1;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            // 
            // delAllButton
            // 
            this.delAllButton.Location = new System.Drawing.Point(696, 286);
            this.delAllButton.Name = "delAllButton";
            this.delAllButton.Size = new System.Drawing.Size(75, 23);
            this.delAllButton.TabIndex = 2;
            this.delAllButton.Text = "Delete All";
            this.delAllButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(696, 411);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(89, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 320);
            this.dataGridView1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(306, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // hourBox
            // 
            this.hourBox.Location = new System.Drawing.Point(522, 90);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(53, 20);
            this.hourBox.TabIndex = 6;
            // 
            // minuteBox
            // 
            this.minuteBox.Location = new System.Drawing.Point(581, 90);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(53, 20);
            this.minuteBox.TabIndex = 7;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(89, 90);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(211, 20);
            this.descriptionBox.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(696, 349);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 597);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.delAllButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Name = "MainWindow";
            this.Text = "MPlanner2021";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button delAllButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.TextBox minuteBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

