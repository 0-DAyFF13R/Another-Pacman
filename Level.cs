using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherPacman
{
    class Level : PictureBox
    {
        public Level()
        {
            InitializeLevel();
        }

        private void InitializeLevel()
        {
            this.BackColor = Color.LightSkyBlue;
            this.Size = new Size(600, 600);
            this.Location = new Point(0, 0);
            this.Name = "Level";
        }
    }
}
