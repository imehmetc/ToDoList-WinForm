namespace ToDoList
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
            lblTodoList = new Label();
            txtMetin = new TextBox();
            lblPandingTasksCount = new Label();
            btnNewToDo = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblTodoList
            // 
            lblTodoList.AutoSize = true;
            lblTodoList.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTodoList.Location = new Point(40, 39);
            lblTodoList.Margin = new Padding(4, 0, 4, 0);
            lblTodoList.Name = "lblTodoList";
            lblTodoList.Size = new Size(137, 37);
            lblTodoList.TabIndex = 0;
            lblTodoList.Text = "ToDo List";
            // 
            // txtMetin
            // 
            txtMetin.Location = new Point(40, 94);
            txtMetin.Name = "txtMetin";
            txtMetin.Size = new Size(314, 29);
            txtMetin.TabIndex = 1;
            // 
            // lblPandingTasksCount
            // 
            lblPandingTasksCount.AutoSize = true;
            lblPandingTasksCount.Location = new Point(40, 466);
            lblPandingTasksCount.Name = "lblPandingTasksCount";
            lblPandingTasksCount.Size = new Size(203, 21);
            lblPandingTasksCount.TabIndex = 2;
            lblPandingTasksCount.Text = "You have 0 panding tasks";
            // 
            // btnNewToDo
            // 
            btnNewToDo.BackColor = Color.DarkSlateBlue;
            btnNewToDo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewToDo.ForeColor = SystemColors.ButtonHighlight;
            btnNewToDo.Location = new Point(360, 82);
            btnNewToDo.Name = "btnNewToDo";
            btnNewToDo.Size = new Size(72, 55);
            btnNewToDo.TabIndex = 3;
            btnNewToDo.Text = "+";
            btnNewToDo.UseVisualStyleBackColor = false;
            btnNewToDo.Click += btnNewToDo_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkSlateBlue;
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(321, 457);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 38);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 533);
            Controls.Add(btnClear);
            Controls.Add(btnNewToDo);
            Controls.Add(lblPandingTasksCount);
            Controls.Add(txtMetin);
            Controls.Add(lblTodoList);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTodoList;
        private TextBox txtMetin;
        private Label lblPandingTasksCount;
        private Button btnNewToDo;
        private Button btnClear;
    }
}
