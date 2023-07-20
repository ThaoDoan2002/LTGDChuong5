using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LTGDC5
{
    public partial class MoveObject : Form
    {
        Random rand = new Random();
        string[] fileNames;
        Point p;
        int count;
        public MoveObject()
        {
            InitializeComponent();
        }

        private void MoveObject_Load(object sender, EventArgs e)
        {
            fileNames = Directory.GetFiles(Application.StartupPath + @"\Image");
            this.addPictureBox();
        }

        private void addPictureBox()
        {
            count++;//Ho tro viec tim kiem control theo Name
            PictureBox pic = new PictureBox();
            pic = new PictureBox();
            pic.Name = count.ToString();
            pic.Image = Image.FromFile(fileNames[rand.Next(fileNames.Length)]);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Location = new Point(0, 0);
            pic.Size = new Size(90, 90);
            this.Controls.Add(pic);
            pic.MouseDown += Pic_MouseDown;
            pic.MouseMove += Pic_MouseMove;
            pic.MouseUp += Pic_MouseUp;

            this.Controls.SetChildIndex(this.panelPic, this.Controls.Count - 1);
        }




        private void Pic_MouseUp(object? sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (panelPic.Bounds.Contains(pic.Bounds))
            {
                panelPic.Controls.Add(pic);
                this.addPictureBox();
            }
        }

        private void Pic_MouseMove(object? sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                pic.Left += e.Location.X - p.X;
                pic.Top += e.Location.Y - p.Y;
            }
        }

        private void Pic_MouseDown(object? sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void MoveObject_KeyDown(object sender, KeyEventArgs e)
        {
            //Tim kiem theo Name cua control, false nghia la khong tim kiem bao
            //gom con ma control do chua.
            Control[] control = this.Controls.Find(count.ToString(), false);
            PictureBox picture = (PictureBox)control[0]; // Match dung control theo Name dau tien.
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (picture.Top > 0)
                        picture.Top -= 10;
                    break;
                case Keys.Down:
                    if (picture.Bottom < ClientRectangle.Height)
                        picture.Top += 10;
                    break;
                case Keys.Left:
                    if (picture.Left > 0)
                        picture.Left -= 10;
                    break;
                case Keys.Right:
                    if (picture.Right < ClientRectangle.Width)
                        picture.Left += 10;
                    break;
            }
            if (panelPic.Bounds.Contains(picture.Bounds))
            {
                panelPic.Controls.Add(picture);
                this.addPictureBox();
            }
        }

        private void panelPic_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void panelPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panelPic.Left += e.Location.X - p.X;
                panelPic.Top += e.Location.Y - p.Y;
            }
        }

    }
}
