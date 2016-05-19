using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chat
{
    public class LetterCircle
    {
        public static readonly int RADIUS = 26;
        public Point Center { get; set; }
        public char Letter { get; set; }
        private int Height;
        public bool IsHit { get; set; }

        public static int i = 0;

        public LetterCircle(Random random, int width, int height)
        {
            int[] Tekst = new int[26] {83,84,79,75,69,73,75,85,80,73,83,78,65,65,78,65,83,84,65,83,73,74,65,120,80,39};
        
            if (i<23){
                Letter = (char)Tekst[i];
                i++;
            }
            else{
                Letter = (char)((int)'A' + random.Next(26));
            }
            int x = random.Next(RADIUS, width - (2 * RADIUS));
            int y = RADIUS;
            Center = new Point(x, y);
            this.Height = height;
            IsHit = false;
        }

        public void Draw(Graphics g)
        {
            if (IsHit)
                g.FillEllipse(Brushes.DarkRed, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);

            else
                g.FillEllipse(Brushes.LightSkyBlue, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);

            Font f = new Font("Arial", 24);
            g.DrawString(string.Format("{0}", Letter), f, Brushes.Black, Center.X - 15, Center.Y - 17);
            f.Dispose();
        }

        public void Move()
        {
            Center = new Point(Center.X, Center.Y + 30);
        }

        public bool ShouldDie()
        {
            return Center.Y > Height - 25;
        }
    }
}
