using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class Collection : Form
    {
        private List<Panel> comicPanels = new List<Panel>(); // Store references to comic panels

        private void AddComic(string imagePath, string comicTitle, int index)
        {
            Panel comicPanel = new Panel();
            comicPanel.Size = new Size(150, 200);
            comicPanel.BorderStyle = BorderStyle.FixedSingle;

            int panelWidth = comicPanel.Width;
            int panelHeight = comicPanel.Height;
            int padding = 15; 

            int x = (index % 9) * (panelWidth + padding); 
            int y = (index / 9) * (panelHeight + padding); 

            comicPanel.Location = new Point(x, y);

            PictureBox pictureBox = new PictureBox();
            //pictureBox.Image = Image.FromFile(imagePath);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Dock = DockStyle.Top;

            Button button = new Button();
            button.Text = comicTitle;
            button.Dock = DockStyle.Bottom;

            //button.Click += (s, e) =>
            //{
            //    RemoveComic(comicPanel); // Call the remove method when the button is clicked
            //};

            comicPanel.Controls.Add(pictureBox);
            comicPanel.Controls.Add(button);

            ScrollPanel.Controls.Add(comicPanel); 
            comicPanels.Add(comicPanel);
        }


        public Collection()
        {
            InitializeComponent();
            string[] comicImages = { "path/to/image1.jpg", "path/to/image2.jpg", "path/to/image3.jpg" };
            string[] comicTitles = { "Co", "Comic Title 2", "Comic Title 3" };

            for (int i = 0; i < 50; i++)
            {
                AddComic("", "co", i);
            }

        }

        private void Collection_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
