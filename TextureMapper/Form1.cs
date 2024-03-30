using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TextureMapper
{
    public partial class Form1 : Form
    {
        string binaryPath;
        string texturePath;
        int XScale;
        int YScale;
        int XPosition;
        int YPosition;

        Bitmap originalImage;

        private bool isDragging = false;
        private Point lastLocation;

        private bool isResizing = false;
        private Point resizingStartPoint;

        public Form1()
        {
            InitializeComponent();

            numXPosition.ValueChanged += NumXPosition_ValueChanged;
            numYPosition.ValueChanged += NumYPosition_ValueChanged;
            numXScale.ValueChanged += NumXScale_ValueChanged;
            numYScale.ValueChanged += NumYScale_ValueChanged;

            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.MouseUp += PictureBox1_MouseUp;

            this.pictureBox1.Paint += new PaintEventHandler(this.pictureBox1_Paint);

            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (new Rectangle(XPosition, YPosition, XScale, YScale).Contains(e.Location))
                {
                    Rectangle resizingRect = new Rectangle(XPosition + XScale - 5, YPosition + YScale - 5, 10, 10);
                    if (resizingRect.Contains(e.Location))
                    {
                        isResizing = true;
                        resizingStartPoint = e.Location;
                    }
                    else
                    {
                        isDragging = true;
                        lastLocation = e.Location;
                    }
                }
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastLocation.X;
                int deltaY = e.Y - lastLocation.Y;

                int newX = XPosition + deltaX;
                int newY = YPosition + deltaY;

                if (newX >= 0 && newX + XScale <= pictureBox1.Width &&
                    newY >= 0 && newY + YScale <= pictureBox1.Height)
                {
                    XPosition = newX;
                    YPosition = newY;

                    lastLocation = e.Location;

                    pictureBox1.Invalidate();

                    UpdateNumericUpDownValues();

                    FUpdateNumericUpDownValues();
                }
            }
            else if (isResizing)
            {
                int deltaX = e.X - resizingStartPoint.X;
                int deltaY = e.Y - resizingStartPoint.Y;

                int newWidth = XScale + deltaX;
                int newHeight = YScale + deltaY;

                if (newWidth > 0 && newHeight > 0 &&
                    XPosition + newWidth <= pictureBox1.Width &&
                    YPosition + newHeight <= pictureBox1.Height)
                {
                    XScale = newWidth;
                    YScale = newHeight;

                    resizingStartPoint = e.Location;

                    pictureBox1.Invalidate();

                    UpdateNumericUpDownValues();

                    FUpdateNumericUpDownValues();
                }
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            isResizing = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(128, Color.Orange)), XPosition, YPosition, XScale, YScale);

            e.Graphics.FillRectangle(Brushes.Blue, XPosition + XScale - 5, YPosition + YScale - 5, 10, 10);
        }

        private void FUpdateNumericUpDownValues()
        {
            numXPosition.Value = XPosition;
            numYPosition.Value = YPosition;
            numXScale.Value = XScale;
            numYScale.Value = YScale;
        }

        private void UpdateNumericUpDownValues()
        {
            numXPosition.ValueChanged -= NumXPosition_ValueChanged;
            numYPosition.ValueChanged -= NumYPosition_ValueChanged;
            numXScale.ValueChanged -= NumXScale_ValueChanged;
            numYScale.ValueChanged -= NumYScale_ValueChanged;

            if (comboBox1.SelectedIndex >= 0)
            {
                int selectedIndex = comboBox1.SelectedIndex;
                numXPosition.Value = XPosition;
                numYPosition.Value = YPosition;
                numXScale.Value = XScale;
                numYScale.Value = YScale;

                XPositions[selectedIndex] = (int)numXPosition.Value;
                YPositions[selectedIndex] = (int)numYPosition.Value;
                XScales[selectedIndex] = (int)numXScale.Value;
                YScales[selectedIndex] = (int)numYScale.Value;
            }

            numXPosition.ValueChanged += NumXPosition_ValueChanged;
            numYPosition.ValueChanged += NumYPosition_ValueChanged;
            numXScale.ValueChanged += NumXScale_ValueChanged;
            numYScale.ValueChanged += NumYScale_ValueChanged;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Title = "Select the Binary File",
                Filter = "Binary File|*.bin|All Files|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                binaryPath = openFileDialog.FileName;

                openFileDialog = new OpenFileDialog()
                {
                    Title = "Select the Texture File",
                    Filter = "Texture file|*.png|All Files|*.*"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    texturePath = openFileDialog.FileName;

                    ReadBinaryFile();
                }
            }
        }

        private int[] XPositions;
        private int[] YPositions;
        private int[] XScales;
        private int[] YScales;

        private void ReadBinaryFile()
        {
            comboBox1.Items.Clear();

            using (FileStream fs = new FileStream(binaryPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                int counter = 0;
                byte[] buffer = new byte[8];

                int fileSize = (int)(fs.Length / buffer.Length);
                XPositions = new int[fileSize];
                YPositions = new int[fileSize];
                XScales = new int[fileSize];
                YScales = new int[fileSize];

                while (fs.Read(buffer, 0, buffer.Length) > 0)
                {
                    short xPosition = BitConverter.ToInt16(buffer, 0);
                    short yPosition = BitConverter.ToInt16(buffer, 2);
                    short xScale = BitConverter.ToInt16(buffer, 4);
                    short yScale = BitConverter.ToInt16(buffer, 6);

                    XPositions[counter] = xPosition;
                    YPositions[counter] = yPosition;
                    XScales[counter] = xScale;
                    YScales[counter] = yScale;

                    comboBox1.Items.Add($"Item {counter}");

                    if (counter == 0)
                    {
                        XPosition = xPosition;
                        YPosition = yPosition;
                        XScale = xScale;
                        YScale = yScale;

                        UpdateNumericUpDownValues();

                        XPosition = xPosition;
                        YPosition = yPosition;
                        XScale = xScale;
                        YScale = yScale;

                        originalImage = (Bitmap)Bitmap.FromFile(texturePath);

                        int imageWidth = originalImage.Width;
                        int imageHeight = originalImage.Height;

                        numXPosition.Maximum = imageWidth;
                        numYPosition.Maximum = imageHeight;
                        numXScale.Maximum = imageWidth;
                        numYScale.Maximum = imageHeight;

                        Rectangle cropRect = new Rectangle(0, 0, imageWidth, imageHeight);
                        Bitmap croppedImage = originalImage.Clone(cropRect, originalImage.PixelFormat);
                        pictureBox1.Image = croppedImage;

                        originalImage = (Bitmap)Bitmap.FromFile(texturePath);

                        pictureBox1.Invalidate();
                    }

                    counter++;
                }

                comboBox1.SelectedIndex = 0;
                pictureBox1.Visible = true;
                numXPosition.Visible = true;
                lblXPosition.Visible = true;
                numYPosition.Visible = true;
                lblYPosition.Visible = true;
                numXScale.Visible = true;
                lblXScale.Visible = true;
                numYScale.Visible = true;
                lblYScale.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < XPositions.Length)
            {
                int xPosition = XPositions[selectedIndex];
                int yPosition = YPositions[selectedIndex];
                int xScale = XScales[selectedIndex];
                int yScale = YScales[selectedIndex];

                XPosition = xPosition;
                YPosition = yPosition;
                XScale = xScale;
                YScale = yScale;

                pictureBox1.Invalidate();

                UpdateNumericUpDownValues();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color corComOpacidade = Color.FromArgb(128, Color.Orange);

            SolidBrush brush = new SolidBrush(corComOpacidade);

            int x = XPosition;
            int y = YPosition;
            int largura = XScale;
            int altura = YScale;

            g.FillRectangle(brush, x, y, largura, altura);
        }

        private void NumXPosition_ValueChanged(object sender, EventArgs e)
        {
            XPosition = (int)numXPosition.Value;
            pictureBox1.Invalidate();
        }

        private void NumYPosition_ValueChanged(object sender, EventArgs e)
        {
            YPosition = (int)numYPosition.Value;
            pictureBox1.Invalidate();
        }

        private void NumXScale_ValueChanged(object sender, EventArgs e)
        {
            XScale = (int)numXScale.Value;
            pictureBox1.Invalidate();
        }

        private void NumYScale_ValueChanged(object sender, EventArgs e)
        {
            YScale = (int)numYScale.Value;
            pictureBox1.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Binary File (*.bin)|*.bin|Todos os arquivos (*.*)|*.*";
            saveFileDialog.Title = "Save Binary File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    for (int i = 0; i < XPositions.Length; i++)
                    {
                        short xPosition = (short)Math.Min(XPositions[i], 65535);
                        short yPosition = (short)Math.Min(YPositions[i], 65535);
                        short xScale = (short)Math.Min(XScales[i], 65535);
                        short yScale = (short)Math.Min(YScales[i], 65535);

                        writer.Write(xPosition);
                        writer.Write(yPosition);
                        writer.Write(xScale);
                        writer.Write(yScale);
                    }
                }

                MessageBox.Show("File saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A very lazy tool made by zMath3usMSF that maps texture based on clipping.\n\nOrder of data in the binary file must be X Position > Y Position > Width and Height, all in Int16.");
        }
    }
}