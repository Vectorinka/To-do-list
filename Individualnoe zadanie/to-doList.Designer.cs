namespace Individualnoe_zadanie
{
    partial class to_doList
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
            this.toDoLabel = new System.Windows.Forms.Label();
            this.inProgressLabel = new System.Windows.Forms.Label();
            this.ReadyLabel = new System.Windows.Forms.Label();
            this.newTask = new System.Windows.Forms.Button();
            this.toDo = new System.Windows.Forms.ListBox();
            this.inProgress = new System.Windows.Forms.ListBox();
            this.Ready = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.reposition = new System.Windows.Forms.Button();
            this.descriptionTask = new System.Windows.Forms.TextBox();
            this.descriptionTaskLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toDoLabel
            // 
            this.toDoLabel.AutoSize = true;
            this.toDoLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDoLabel.Location = new System.Drawing.Point(24, 119);
            this.toDoLabel.Name = "toDoLabel";
            this.toDoLabel.Size = new System.Drawing.Size(89, 22);
            this.toDoLabel.TabIndex = 3;
            this.toDoLabel.Text = "Сделать: ";
            // 
            // inProgressLabel
            // 
            this.inProgressLabel.AutoSize = true;
            this.inProgressLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inProgressLabel.Location = new System.Drawing.Point(24, 216);
            this.inProgressLabel.Name = "inProgressLabel";
            this.inProgressLabel.Size = new System.Drawing.Size(112, 22);
            this.inProgressLabel.TabIndex = 4;
            this.inProgressLabel.Text = "В процессе:";
            // 
            // ReadyLabel
            // 
            this.ReadyLabel.AutoSize = true;
            this.ReadyLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadyLabel.Location = new System.Drawing.Point(24, 313);
            this.ReadyLabel.Name = "ReadyLabel";
            this.ReadyLabel.Size = new System.Drawing.Size(74, 22);
            this.ReadyLabel.TabIndex = 5;
            this.ReadyLabel.Text = "Готово:";
            // 
            // newTask
            // 
            this.newTask.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTask.Location = new System.Drawing.Point(590, 47);
            this.newTask.Name = "newTask";
            this.newTask.Size = new System.Drawing.Size(134, 69);
            this.newTask.TabIndex = 6;
            this.newTask.Text = "Новая задача";
            this.newTask.UseVisualStyleBackColor = true;
            this.newTask.Click += new System.EventHandler(this.newTask_Click);
            // 
            // toDo
            // 
            this.toDo.FormattingEnabled = true;
            this.toDo.Location = new System.Drawing.Point(28, 144);
            this.toDo.Name = "toDo";
            this.toDo.Size = new System.Drawing.Size(556, 69);
            this.toDo.TabIndex = 8;
            // 
            // inProgress
            // 
            this.inProgress.FormattingEnabled = true;
            this.inProgress.Location = new System.Drawing.Point(28, 241);
            this.inProgress.Name = "inProgress";
            this.inProgress.Size = new System.Drawing.Size(556, 69);
            this.inProgress.TabIndex = 9;
            // 
            // Ready
            // 
            this.Ready.FormattingEnabled = true;
            this.Ready.Location = new System.Drawing.Point(28, 338);
            this.Ready.Name = "Ready";
            this.Ready.Size = new System.Drawing.Size(556, 69);
            this.Ready.TabIndex = 10;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(590, 338);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(134, 69);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // reposition
            // 
            this.reposition.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reposition.Location = new System.Drawing.Point(590, 210);
            this.reposition.Name = "reposition";
            this.reposition.Size = new System.Drawing.Size(134, 34);
            this.reposition.TabIndex = 12;
            this.reposition.Text = "Переместить";
            this.reposition.UseVisualStyleBackColor = true;
            this.reposition.Click += new System.EventHandler(this.reposition_Click);
            // 
            // descriptionTask
            // 
            this.descriptionTask.Location = new System.Drawing.Point(27, 47);
            this.descriptionTask.Multiline = true;
            this.descriptionTask.Name = "descriptionTask";
            this.descriptionTask.Size = new System.Drawing.Size(557, 69);
            this.descriptionTask.TabIndex = 13;
            // 
            // descriptionTaskLabel
            // 
            this.descriptionTaskLabel.AutoSize = true;
            this.descriptionTaskLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTaskLabel.Location = new System.Drawing.Point(24, 16);
            this.descriptionTaskLabel.Name = "descriptionTaskLabel";
            this.descriptionTaskLabel.Size = new System.Drawing.Size(173, 22);
            this.descriptionTaskLabel.TabIndex = 14;
            this.descriptionTaskLabel.Text = "Описание задания:";
            this.descriptionTaskLabel.Click += new System.EventHandler(this.descriptionTaskLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(590, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Время:";
            // 
            // NameBox
            // 
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Items.AddRange(new object[] {
            "Иванов И. И.",
            "Фетисов С. И."});
            this.NameBox.Location = new System.Drawing.Point(203, 19);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(185, 21);
            this.NameBox.TabIndex = 16;
            this.NameBox.Text = "...";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(590, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Переместить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // to_doList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTaskLabel);
            this.Controls.Add(this.descriptionTask);
            this.Controls.Add(this.reposition);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Ready);
            this.Controls.Add(this.inProgress);
            this.Controls.Add(this.toDo);
            this.Controls.Add(this.newTask);
            this.Controls.Add(this.ReadyLabel);
            this.Controls.Add(this.inProgressLabel);
            this.Controls.Add(this.toDoLabel);
            this.Name = "to_doList";
            this.Text = "to_doList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label toDoLabel;
        private System.Windows.Forms.Label inProgressLabel;
        private System.Windows.Forms.Label ReadyLabel;
        private System.Windows.Forms.Button newTask;
        private System.Windows.Forms.ListBox toDo;
        private System.Windows.Forms.ListBox inProgress;
        private System.Windows.Forms.ListBox Ready;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button reposition;
        private System.Windows.Forms.TextBox descriptionTask;
        private System.Windows.Forms.Label descriptionTaskLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NameBox;
        private System.Windows.Forms.Button button1;
    }
}