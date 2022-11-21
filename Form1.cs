using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conway_s_Game_Of_Life
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        private int pxSize;
        private bool[,] field;
        private int rows;
        private int columns;
        private Color bgrColor = Color.Black;
        private SolidBrush pxColor = new SolidBrush(Color.Crimson);
        private bool isStarted = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            if (timer.Enabled) return;
            if (!isStarted)
            {
                isStarted = true;
                pxSize = (int)nud_Resolution.Value;
                rows = pictureBox.Height / pxSize;
                columns = pictureBox.Width / pxSize;
                field = new bool[columns, rows];

                GenerateField();
            }
            timer.Start();

        }

        private void StopGame()
        {
            if (!timer.Enabled) return;
            timer.Stop();
        }

        private void RefreshGame()
        {
            if (!timer.Enabled) StartGame();
            GenerateField();
        }

        private void GenerateField()
        {
            pxSize = (int)nud_Resolution.Value;
            rows = pictureBox.Height / pxSize;
            columns = pictureBox.Width / pxSize;
            field = new bool[columns, rows];

            FillField();
        }

        private void FillField()
        {
            Random random = new Random();
            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)nud_Density.Value) == 0;
                }
            }
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(pictureBox.Image);
        }

        private void NextGeneration()
        {
            graphics.Clear(bgrColor);

            bool[,] newField = new bool[columns, rows];

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    int neighboursCount = CountNeighbours(x, y);
                    bool hasLife = field[x, y];
                    if (!hasLife && neighboursCount == (int)nud_NeighboursToBorn.Value)
                    {
                        newField[x, y] = true;
                    }
                    else if (hasLife && (neighboursCount < (int)nud_MinNeighboursForSurvival.Value || neighboursCount > (int)nud_MaxNeighboursForSurvival.Value))
                    {
                        newField[x, y] = false;
                    }
                    else
                    {
                        newField[x, y] = field[x, y];
                    }

                    if (hasLife)
                    {
                        graphics.FillRectangle(pxColor, x * pxSize, y * pxSize, pxSize, pxSize);
                    }
                }
            }
            field = newField;
            pictureBox.Refresh();

        }

        private int CountNeighbours(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int col = (x + i + columns) % columns;
                    int row = (y + j + rows) % rows;

                    bool IsSelfChecking = col == x && row == y;
                    bool hasLife = field[col, row];

                    if (hasLife && !IsSelfChecking)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshGame();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer.Enabled) return;

            int x = e.Location.X / pxSize;
            int y = e.Location.Y / pxSize;

            if (e.Button == MouseButtons.Left && IsOnField(x, y)) field[x, y] = true;
            if (e.Button == MouseButtons.Right && IsOnField(x, y)) field[x, y] = false;
        }

        private bool IsOnField(int x, int y) => x >= 0 && y >= 0 && x <= columns && y <= rows;

        private void nud_SPS_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = (int)(1000 / nud_SPS.Value);
        }

        private void button_bgrColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            if (cd.ShowDialog() == DialogResult.Cancel) return;
            bgrColor = cd.Color;
        }

        private void button_pxColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            if (cd.ShowDialog() == DialogResult.Cancel) return;
            pxColor = new SolidBrush(cd.Color);
        }
    }    
}
