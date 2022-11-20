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
        private int resolution;
        private bool[,] field;
        private int rows;
        private int columns;
        private int currentGeneration = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            if (timer.Enabled) return;

            currentGeneration = 0;

            nud_Resolution.Enabled = false;
            nud_Density.Enabled = false;
            nud_NeighboursToBorn.Enabled = false;
            nud_MinNeighboursForSurvival.Enabled = false;
            nud_MaxNeighboursForSurvival.Enabled = false;


            resolution = (int)nud_Resolution.Value;
            rows = pictureBox.Height / resolution;
            columns = pictureBox.Width / resolution;
            field = new bool[columns, rows];

            Random random = new Random();
            for (int x =0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)nud_Density.Value) == 0;
                }
            }

            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(pictureBox.Image);

            timer.Start();
        }

        private void StopGame()
        {
            if (!timer.Enabled) return;

            timer.Stop();
            nud_Resolution.Enabled = true;
            nud_Density.Enabled = true;
            nud_NeighboursToBorn.Enabled = true;
            nud_MinNeighboursForSurvival.Enabled = true;
            nud_MaxNeighboursForSurvival.Enabled = true;
        }

        private void NextGeneration()
        {
            graphics.Clear(Color.Black);

            bool[,] newField = new bool[columns, rows];

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    int neighboursCount = CountNeighbours(x,y);
                    bool hasLife = field[x, y];
                    if(!hasLife && neighboursCount == (int)nud_NeighboursToBorn.Value)
                    {
                        newField[x, y] = true;
                    }
                    else if(hasLife &&(neighboursCount < (int)nud_MinNeighboursForSurvival.Value || neighboursCount > (int)nud_MaxNeighboursForSurvival.Value))
                    {
                        newField[x, y] = false;
                    }
                    else
                    {
                        newField[x, y] = field[x, y];
                    }

                    if(hasLife)
                    {
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution, resolution);
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
            Text = $"Current generation {currentGeneration++}";
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = $"Текущее поколение {currentGeneration}";
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer.Enabled) return;

            int x = e.Location.X / resolution;
            int y = e.Location.Y / resolution;

            if (e.Button == MouseButtons.Left && IsOnField(x,y)) field[x,y] = true;       
            if (e.Button == MouseButtons.Right && IsOnField(x, y)) field[x, y] = false;        
        }

        private bool IsOnField(int x, int y) => x >= 0 && y >= 0 && x <= columns && y <= rows;
    }
}
