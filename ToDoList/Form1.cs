namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtMetin.MaxLength = 25;
            PandingTasksList();
        }

        Todo todo = new Todo();
        private void btnNewToDo_Click(object sender, EventArgs e)
        {
            if (txtMetin.Text.Trim() != "")
            {
                todo.NewTodo = txtMetin.Text;
                Label lbl = new Label();
                lbl.Name = $"label_{todo.TodoList.Count}";

                if (todo.NewTodo.Length > 25)
                {
                    string truncatedString = todo.NewTodo.Substring(0,20) + "...";
                    lbl.Text = truncatedString;
                }
                else
                    lbl.Text = todo.NewTodo;
                
                lbl.AutoSize = false;
                lbl.Width = 314;
                lbl.Height = 30;
                lbl.BackColor = Color.Silver;
                lbl.Left = 40;
                lbl.Top = EklenecegiYer(10) - 90;
                
                this.Controls.Add(lbl);

                todo.AddToDo(lbl);
                PandingTasksList();

                
                Button btn = new Button();
                btn.Text = "Sil";
                btn.Width = 75;
                btn.Height = 30;
                btn.Left = 238;
                btn.BackColor = Color.White;
                btn.Parent = lbl;
                
                btn.Click += Btn_Click;
                
                lbl.Controls.Add(btn);

            }
            else
                MessageBox.Show("Boş alan bırakmayın!");
        }

        public void PandingTasksList()
        {
            lblPandingTasksCount.Text = $"You have {todo.TodoList.Count} panding tasks";
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            Label lbl = btn.Parent as Label;

            this.Controls.Remove(lbl);
            todo.TodoList.Remove(lbl);
            PandingTasksList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control item = this.Controls[i];
                if (item is Label && ((Label)item).Name.Contains("label"))
                {
                    this.Controls.RemoveAt(i);
                    if (todo.TodoList.Contains((Label)item))
                    {
                        todo.TodoList.Remove((Label)item);
                        PandingTasksList();
                    }
                }
            }
        }

        public int EklenecegiYer(int spacing)
        {
            int toplam = 0;
            foreach (Control item in this.Controls)
            {
                toplam += item.Height + spacing;
            }

            return toplam;
        }
    }
}
