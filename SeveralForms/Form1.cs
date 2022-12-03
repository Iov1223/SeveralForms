using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeveralForms
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }
        private RichTextBox richTextBoxB;
        private RichTextBox richTextBoxC;
        private Form refFromB = new Form();
        private Form refFromC = new Form();
        //private void createForm(string text, string where1, string where2)
        //{
        //    Form newForm = new Form();
        //    newForm.Text = text;
        //    var SizeFirst = SystemInformation.PrimaryMonitorMaximizedWindowSize;
        //    newForm.MaximumSize = new Size(SizeFirst.Width / 6, SizeFirst.Height / 3);
        //    newForm.MinimumSize = new Size(SizeFirst.Width / 6, SizeFirst.Height / 3);

        //    RichTextBox richtextBox = new RichTextBox();
        //    richtextBox.Width = 221;
        //    richtextBox.Height = 200;
        //    newForm.Controls.Add(richtextBox);

        //    Point pointTextBox = richtextBox.Location;
        //    pointTextBox.X = 10;
        //    pointTextBox.Y = 33;
        //    richtextBox.Location = pointTextBox;

        //    Button buttonWhere1 = new Button();
        //    buttonWhere1.Width = 90;
        //    newForm.Controls.Add(buttonWhere1);

        //    buttonWhere1.Text = where1;

        //    Point pointbuttonWhere1 = buttonWhere1.Location;
        //    pointbuttonWhere1.X = 10;
        //    pointbuttonWhere1.Y = 5;
        //    buttonWhere1.Location = pointbuttonWhere1;

        //    Button buttonWhere2 = new Button();
        //    buttonWhere2.Width = 90;
        //    newForm.Controls.Add(buttonWhere2);
        //    buttonWhere1.MouseClick += buttonWhereA_MouseClick;
        //    buttonWhere1.MouseClick += buttonWhereB_MouseClick;
        //    buttonWhere2.MouseClick += buttonWhereC_MouseClick;
        //    buttonWhere2.Text = where2;

        //    Point pointbuttonWhere2 = buttonWhere2.Location;
        //    pointbuttonWhere2.X = 140;
        //    pointbuttonWhere2.Y = 5;
        //    buttonWhere2.Location = pointbuttonWhere2;

        //    newForm.Show();
        //}

        private void FormBase_Load(object sender, EventArgs e)
        {
            var SizeFirst = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.MaximumSize = new Size(SizeFirst.Width / 5, SizeFirst.Height / 2);
            this.MinimumSize = new Size(SizeFirst.Width / 5, SizeFirst.Height / 2);
            this.Location = new Point((int)((double)SizeFirst.Width / 2.5), (int)((double)SizeFirst.Height /3.5));
        }
        private void buttonCreateFormB_MouseClick(object sender, MouseEventArgs e)
        {
            //createForm("Форма \"B\"", "На форму \"А\"", "На форму \"C\"");
            Form newFormB = new Form();
            newFormB.Text = "Форма \"B\"";
            refFromB = newFormB;
            var SizeFirst = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            newFormB.MaximumSize = new Size(SizeFirst.Width / 6, SizeFirst.Height / 3);
            newFormB.MinimumSize = new Size(SizeFirst.Width / 6, SizeFirst.Height / 3);

            richTextBoxB = new RichTextBox();
            richTextBoxB.Width = 221;
            richTextBoxB.Height = 200;
            newFormB.Controls.Add(richTextBoxB);

            Point pointTextBox = richTextBoxB.Location;
            pointTextBox.X = 10;
            pointTextBox.Y = 33;
            richTextBoxB.Location = pointTextBox;

            Button buttonWhereA = new Button();
            buttonWhereA.Width = 90;
            newFormB.Controls.Add(buttonWhereA);

            buttonWhereA.MouseClick += buttonBWhereA_MouseClick;
            buttonWhereA.Text = "На форму \"А\"";

            Point pointbuttonWhereA = buttonWhereA.Location;
            pointbuttonWhereA.X = 10;
            pointbuttonWhereA.Y = 5;
            buttonWhereA.Location = pointbuttonWhereA;

            Button buttonWhereC = new Button();
            buttonWhereC.Width = 90;
            newFormB.Controls.Add(buttonWhereC);
            buttonWhereC.MouseClick += buttonBWhereC_MouseClick;
            buttonWhereC.Text = "На форму \"С\"";

            Point pointbuttonWhereC = buttonWhereC.Location;
            pointbuttonWhereC.X = 140;
            pointbuttonWhereC.Y = 5;
            buttonWhereC.Location = pointbuttonWhereC;

            newFormB.Show();

        }

        private void buttonCreateFormC_MouseClick(object sender, MouseEventArgs e)
        {
            // refWhereFrom = null;
            //createForm("Форма \"C\"", "На форму \"А\"", "На форму \"В\"");
            Form newFormC = new Form();
            newFormC.Text = "Форма \"C\"";
            refFromC = newFormC;
            var Size = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            newFormC.MaximumSize = new Size(Size.Width / 6, Size.Height / 3);
            newFormC.MinimumSize = new Size(Size.Width / 6, Size.Height / 3);

            richTextBoxC = new RichTextBox();
            richTextBoxC.Width = 221;
            richTextBoxC.Height = 200;
            newFormC.Controls.Add(richTextBoxC);

            Point pointTextBox = richTextBoxC.Location;
            pointTextBox.X = 10;
            pointTextBox.Y = 33;
            richTextBoxC.Location = pointTextBox;

            Button buttonWhereA = new Button();
            buttonWhereA.Width = 90;
            newFormC.Controls.Add(buttonWhereA);
            buttonWhereA.MouseClick += buttonCWhereA_MouseClick;
            buttonWhereA.Text = "На форму \"А\"";

            Point pointbuttonWhereA = buttonWhereA.Location;
            pointbuttonWhereA.X = 10;
            pointbuttonWhereA.Y = 5;
            buttonWhereA.Location = pointbuttonWhereA;

            Button buttonWhereB = new Button();
            buttonWhereB.Width = 90;
            newFormC.Controls.Add(buttonWhereB);
            buttonWhereB.MouseClick += buttonCWhereB_MouseClick;
            buttonWhereB.Text = "На форму \"B\"";

            Point pointbuttonWhereB = buttonWhereB.Location;
            pointbuttonWhereB.X = 140;
            pointbuttonWhereB.Y = 5;
            buttonWhereB.Location = pointbuttonWhereB;

            newFormC.Show();
        }
        private void buttonBWhereA_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBoxA.Text = richTextBoxB.Text;
        }
        private void buttonBWhereC_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBoxC.Text = richTextBoxB.Text;
        }
        private void buttonCWhereA_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBoxA.Text = richTextBoxC.Text;
        }
        private void buttonCWhereB_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBoxB.Text = richTextBoxC.Text;
        }

        private void buttonToFormB_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBoxB.Text = richTextBoxA.Text;
        }

        private void buttonToFormC_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBoxC.Text = richTextBoxA.Text;
        }

        
    }
}
