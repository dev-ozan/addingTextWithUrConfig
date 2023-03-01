namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                   

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void kirmiziButton_Click(object sender, EventArgs e)
        {
            // TextBox txt = new TextBox();
            // txt.Width = 200;
            // txt.BackColor = Color.Red;
            // panelLayout.Controls.Add(txt);
            TextBox olustur = TextBoxOlustur();
            olustur.BackColor = Color.Red;

        }

        private void maviButton_Click(object sender, EventArgs e)
        {
            // TextBox txt = new TextBox();
            // txt.Width = 200;
            // txt.BackColor = Color.Blue;
            // panelLayout.Controls.Add(txt);

            
            TextBox olustur = TextBoxOlustur();
            olustur.BackColor = Color.Blue;
        }

        private void yesilButton_Click(object sender, EventArgs e)
        {
            //TextBox txt = new TextBox();
            //txt.Width = 200;
            //txt.BackColor = Color.Green;
            //panelLayout.Controls.Add(txt);

            TextBox olustur = TextBoxOlustur();
            olustur.BackColor = Color.Green;

        }

        private void sariButton_Click(object sender, EventArgs e)
        {
            // TextBox txt = new TextBox();
            //txt.Width = 200;
            //txt.BackColor = Color.Yellow;
            //panelLayout.Controls.Add(txt);
            TextBox olustur = TextBoxOlustur();
            olustur.BackColor = Color.Yellow;
        }

        private void originalButton_Click(object sender, EventArgs e)
        {
            /*/   TextBox txt = new TextBox();
               txt.Width = 200;
               txt.BackColor = Color.White;
               panelLayout.Controls.Add(txt);
            /*/
            TextBox olustur = TextBoxOlustur();
            olustur.BackColor = Color.White;

        }
        TextBox TextBoxOlustur()
        {
            TextBox txt = new TextBox();                   

            txt.Width = 200;
            txt.BackColor = Color.Red;
            panelLayout.Controls.Add(txt);
            return txt;

        }


    }
}