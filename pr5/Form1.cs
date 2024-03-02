namespace pr5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            if (e.Button == MouseButtons.Left)
            {
                Panel panel = new Panel();
                panel.Size = new Size(200, 200);

                Label label = new Label();
                label.Location = e.Location;
                label.Size = new Size(rnd.Next(50, 50), rnd.Next(50, 50));
                ForeColor = Color.Red;
                label.Text = "1231231";
                
                Button button = new Button();
                button.Location = e.Location;
                button.Size = new Size(rnd.Next(50, 100), rnd.Next(50, 100));
                this.Controls.Add(panel);
                this.Controls.Add(label);
                this.Controls.Add(button);
                
            }
            else if (e.Button == MouseButtons.Right)
            {
                Controls.Clear();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
