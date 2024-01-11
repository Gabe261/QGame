/* GSiewertQGame.cs
* Assignment 2
* Revision History
* Gabriel Siewert, 2023.10.30: Created Program
* Gabriel Siewert, 2023.11.05: Finilized Project
* Gabriel Siewert, 2023.11.29: Implemented The PlayForm
* Gabriel Siewert, 2023.11.29: Finilized PlayForm 
*/

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GSiewertQGame
{
    /// <summary>
    /// The DesignForm allows users to create and save levels for the QGame
    /// </summary>
    public partial class DesignForm : Form
    {
        // 2D QPictureBpx array reference to represent the gameboard
        private QPictureBox[,] designBoard;

        // an enum that controls the toolbox states
        private enum designStates
        {
            None,
            Wall,
            RedDoor,
            GreenDoor,
            RedBox,
            GreenBox
        }
        private designStates currentTool = designStates.None;

        // Constant Variables
        private const int PICBOX_WIDTH = 75;
        private const int PICBOX_DISPLACMENT_X = 200;
        private const int PICBOX_DISPLACMENT_Y = 125;

        /// <summary>
        /// The default constructor the the DesignForm
        /// </summary>
        public DesignForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The Generate button validates the row and colunm inputs, if valid a 
        /// QPictureBox grid of controls is created on the form
        /// </summary>
        /// <param name="sender"> Generate buttons information </param>
        /// <param name="e"> Contains the event data </param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Parse row and column textboxs into two int values with proper error handling
            int rows;
            int cols;
            try
            {
                rows = int.Parse(txtRows.Text);
                if (rows < 0)
                    throw new Exception("Rows must be a positive integer");

                try
                {
                    cols = int.Parse(txtColumns.Text);
                    if (cols < 0)
                        throw new Exception("Columns must be a positive integer");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Columns Error: {ex.Message}", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rows Error: {ex.Message}", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // If a reference to a gameboard already exsists, either replace or cancel
            if (designBoard != null)
            {
                DialogResult newLevelDialog = MessageBox.Show("Do you eant to create a new level?\nIf you do, the current level will be lost", "QGame", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (newLevelDialog == DialogResult.Yes)
                {
                    ClearBoard();
                }
                else if (newLevelDialog == DialogResult.No)
                {
                    return;
                }
            }
            // Create new reference for designBoard array and populate with QPicturebox's
            designBoard = new QPictureBox[rows, cols];
            for (int i = 0; i < designBoard.GetLength(0); i++)
            {
                for (int j = 0; j < designBoard.GetLength(1); j++)
                {
                    QPictureBox pictureBox = new QPictureBox();
                    pictureBox.Size = new Size(PICBOX_WIDTH, PICBOX_WIDTH);
                    pictureBox.Location = new Point((PICBOX_WIDTH * j) + PICBOX_DISPLACMENT_X, (PICBOX_WIDTH * i) + PICBOX_DISPLACMENT_Y);
                    pictureBox.BorderStyle = BorderStyle.Fixed3D;
                    pictureBox.Click += PicBox_Click;
                    pictureBox.BackColor = Color.White;
                    pictureBox.MouseEnter += PicBox_Enter;
                    pictureBox.MouseLeave += PicBox_Leave;
                    designBoard[i, j] = pictureBox;
                    Controls.Add(pictureBox);
                }
            }
        }
        /// <summary>
        /// Makes all the QPictureBox's in the designBoard array invisable and inoperable
        /// </summary>
        private void ClearBoard()
        {
            for (int i = 0; i < designBoard.GetLength(0); i++)
            {
                for (int j = 0; j < designBoard.GetLength(1); j++)
                {
                    designBoard[i, j].Visible = false;
                }
            }
        }
        /// <summary>
        /// When a QPicutre box is clicked, a picture and new value is assiged depending on which current tool is selected
        /// </summary>
        /// <param name="sender"> Which QPicbox has been clicked </param>
        /// <param name="e"> Contains the event data </param>
        private void PicBox_Click(object sender, EventArgs e)
        {
            QPictureBox picBox = (QPictureBox)sender;
            switch (currentTool)
            {
                case designStates.None:
                    picBox.Image = null;
                    picBox.Value = (int)designStates.None;
                    break;
                case designStates.Wall:
                    picBox.Image = Properties.Resources.Wall;
                    picBox.Value = (int)designStates.Wall;
                    break;
                case designStates.RedDoor:
                    picBox.Image = Properties.Resources.RedDoor;
                    picBox.Value = (int)designStates.RedDoor;
                    break;
                case designStates.GreenDoor:
                    picBox.Image = Properties.Resources.GreenDoor;
                    picBox.Value = (int)designStates.GreenDoor;
                    break;
                case designStates.RedBox:
                    picBox.Image = Properties.Resources.RedBox;
                    picBox.Value = (int)designStates.RedBox;
                    break;
                case designStates.GreenBox:
                    picBox.Image = Properties.Resources.GreenBox;
                    picBox.Value = (int)designStates.GreenBox;
                    break;
                default:
                    break;
            }
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        /// <summary>
        /// Event for when mouse enters picbox contorl changing the backgound darker
        /// </summary>
        /// <param name="sender"> Which QPicbox is being hovered </param>
        /// <param name="e"> Contains the event data </param>
        private void PicBox_Enter(object sender, EventArgs e)
        {
            QPictureBox picBox = (QPictureBox)sender;
            picBox.BackColor = Color.LightGray;
        }
        /// <summary>
        /// Event for when mouse exits picbox contorl reverting the background to normal
        /// </summary>
        /// <param name="sender"> Which QPicbox has stoped being hovered </param>
        /// <param name="e"> Contains the event data </param>
        private void PicBox_Leave(object sender, EventArgs e)
        {
            QPictureBox picBox = (QPictureBox)sender;
            picBox.BackColor = Color.White;
        }
        /// <summary>
        /// When a button in the tool box is selected, the currentTool enum variable is changed to
        /// corrisponding value in the buttons imageList
        /// </summary>
        /// <param name="sender"> Which toolbox button has been clicked </param>
        /// <param name="e"> Contains the event data </param>
        private void ToolBoxClicked(object sender, EventArgs e)
        {
            Button btnClicked = (Button)sender;
            currentTool = (designStates)btnClicked.ImageIndex;
        }
        /// <summary>
        /// Opens save file dialog and writes current levels information into that .txt file 
        /// </summary>
        /// <param name="sender"> Object repesenting save toolstrip item </param>
        /// <param name="e"> Contains the event data </param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the designBoard isn't referencing anything, puch user to create a level
            if(designBoard == null)
            {
                MessageBox.Show("Start by creating a level to save", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int doorCount = 0;
            int wallCount = 0;
            int boxCount = 0;
            dlgSave.Filter = "Text files|*.txt|All files|*.*";
            dlgSave.Title = "Save your level";
            DialogResult save = dlgSave.ShowDialog();
            switch (save)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    try
                    {
                        StreamWriter writer = new StreamWriter(dlgSave.FileName);
                        // Write the amount of rows and columns in file
                        writer.WriteLine($"{designBoard.GetLength(0)}\n{designBoard.GetLength(1)}");
                        // Write 0-5 for which image is in the picture box 
                        int item;
                        for (int i = 0; i < designBoard.GetLength(0); i++)
                        {
                            for (int j = 0; j < designBoard.GetLength(1); j++)
                            {
                                switch (designBoard[i, j].Value)
                                {
                                    case 1:
                                        item = 1;
                                        wallCount++;
                                        break;
                                    case 2:
                                        item = 2;
                                        doorCount++;
                                        break;
                                    case 3:
                                        item = 3;
                                        doorCount++;
                                        break;
                                    case 4:
                                        item = 4;
                                        boxCount++;
                                        break;
                                    case 5:
                                        item = 5;
                                        boxCount++;
                                        break;
                                    default:
                                        item = 0;
                                        break;
                                }
                                writer.WriteLine($"{i}\n{j}\n{item}");
                            }
                        }
                        writer.Close();
                        MessageBox.Show($"File saved successfully:\nTotal number of walls: {wallCount}\nTotal number of doors: {doorCount}\nTotal number of boxes: {boxCount}", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Exits the current design form
        /// </summary>
        /// <param name="sender"> Object repesenting close toolstrip item </param>
        /// <param name="e"> Contains the event data </param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
