using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sayf_Viewer
{
    public partial class Form1 : Form
    {
        public static List<Bitmap> bmp_images = new List<Bitmap>();
        public static int count = 0;
        public static int numFiles = 0;
        public static string directory = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Clear the picture box
            pbView.Image = null;

            // Clear the array
            bmp_images.Clear();

            // Reset the count
            count = 0;

            // Reset the label
            lblFrame.Text = "";

            // Reset Number of Files
            numFiles = 0;

            btnNext.Enabled = false;
            btnPrev.Enabled = false;
            btnGenerate.Enabled = false;
            // Get the number of files in the directory
            string[] files = System.IO.Directory.GetFiles(directory);
            numFiles = files.Length;

            for (int k = 0; k < numFiles; k++)
            {
                // Open a textfile, and parse the 50x50 grid of numbers seperated by spaces
                string[] lines = System.IO.File.ReadAllLines(directory + @"\" + k.ToString() + ".txt");
                String[,] grid = new String[50, 50];
                for (int j = 0; j < 50; j++)
                {
                    string[] line = lines[j].Split(' ');
                    for (int i = 0; i < 50; i++)
                    {
                        grid[i, j] = line[i];
                    }
                }

                // Create a bitmap that each square is 10x10 pixels in size
                Bitmap bmp = new Bitmap(500, 500);
                Graphics g = Graphics.FromImage(bmp);

                // Draw the grid
                for (int i = 0; i < 50; i++)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        // Set the color based on the number
                        // 1 is red, 2 is green, 3 is blue, 4 is yellow, 5 is purple, 6 is cyan, 7 is brown, 8 is black, 9 is grey, 10 is orange

                        if (grid[i, j] == txtPathIndicator.Text)
                        {
                            // Draw a star in the square
                            g.FillRectangle(Brushes.Black, i * 10, j * 10, 10, 10);
                            g.FillRectangle(Brushes.Violet, i * 10 + 2, j * 10 + 2, 6, 6);
                        }
                        else if (grid[i, j] == txtApple.Text)
                        {
                            g.FillRectangle(Brushes.Black, i * 10, j * 10, 10, 10);
                            g.FillPolygon(Brushes.Red, new Point[] { new Point(i * 10 + 2, j * 10 + 2), new Point(i * 10 + 8, j * 10 + 2), new Point(i * 10 + 5, j * 10 + 8) });
                        }
                        else if (grid[i, j] == txtBlack.Text)
                        {
                            g.FillRectangle(Brushes.Black, i * 10, j * 10, 10, 10);
                        }
                        else if (grid[i, j] == txtGreen.Text)
                        {
                            g.FillRectangle(Brushes.Green, i * 10, j * 10, 10, 10);
                        }
                        else if (grid[i, j] == txtBlue.Text)
                        {
                            g.FillRectangle(Brushes.Blue, i * 10, j * 10, 10, 10);
                        }
                        else if (grid[i, j] == txtYellow.Text)
                        {
                            g.FillRectangle(Brushes.Yellow, i * 10, j * 10, 10, 10);
                        }
                        else if (grid[i, j] == txtPurple.Text)
                        {
                            g.FillRectangle(Brushes.Purple, i * 10, j * 10, 10, 10);
                        }
                        else if (grid[i, j] == txtCyan.Text)
                        {
                            g.FillRectangle(Brushes.Cyan, i * 10, j * 10, 10, 10);
                        }
                        else if (grid[i, j] == txtBrown.Text)
                        {
                            g.FillRectangle(Brushes.Brown, i * 10, j * 10, 10, 10);
                        }
                        else if (grid[i, j] == txtRed.Text)
                        {
                            g.FillRectangle(Brushes.Red, i * 10, j * 10, 10, 10);
                        }
                        else if (grid[i, j] == txtOrange.Text)
                        {
                            g.FillRectangle(Brushes.Orange, i * 10, j * 10, 10, 10);
                        }
                        else if (grid[i, j] == txtWhite.Text)
                        {
                            g.FillRectangle(Brushes.White, i * 10, j * 10, 10, 10);
                        }
                        else
                        {
                            g.FillRectangle(Brushes.BlueViolet, i * 10, j * 10, 10, 10);
                        }
                    }
                }

                // Save the bitmap to an array
                bmp_images.Add(bmp);

                try
                {
                    timer.Interval = int.Parse(txtPlaybackSpeed.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                timer.Enabled = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (count < numFiles)
            {
                try
                {
                    pbView.Image = bmp_images[count];
                    count++;
                    lblFrame.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                timer.Enabled = false;
                MessageBox.Show("Done");

                // Enable the button
                btnNext.Enabled = true;
                btnPrev.Enabled = true;
                btnGenerate.Enabled = true;

                trackBar.Enabled = true;
                trackBar.Maximum = numFiles;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Go to the next element in the array if it exists
            if (count < numFiles)
            {
                pbView.Image = bmp_images[count];
                count++;
                lblFrame.Text = count.ToString();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Go to the previous element in the array if it exists
            if (count > 0)
            {
                count--;
                pbView.Image = bmp_images[count];
                lblFrame.Text = count.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Print the results string to a PDF
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                directory = folderDlg.SelectedPath;
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (trackBar.Value < numFiles)
            {
                count = trackBar.Value;
                pbView.Image = bmp_images[count];
                lblFrame.Text = count.ToString();
            }
        }
    }
}