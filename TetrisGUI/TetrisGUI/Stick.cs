﻿namespace Tetris
{
    internal class Stick : Figure
    {
        public Stick(int x, int y, char c)
        {
            Points[0] = new Point(x, y, c);
            Points[1] = new Point(x, y + 1, c);
            Points[2] = new Point(x, y + 2, c);
            Points[3] = new Point(x, y + 3, c);
            Draw();
        }
        public override void Rotate()
        {
            if (Points[0].X == Points[1].X)
            {
                RotateHorisontal();
            }
            else
            {
                RotateVertical();
            }

        }

        private void RotateVertical()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].X = Points[0].X;
                Points[i].Y = Points[0].Y + i;
            }
        }

        private void RotateHorisontal()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].Y = Points[0].Y;
                Points[i].X = Points[0].X + i;
            }
        }
    }
}