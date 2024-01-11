/* GSiewertQGame.cs
* Assignment 2
* Revision History
* Gabriel Siewert, 2023.10.30: Created Program
* Gabriel Siewert, 2023.11.05: Finilized Project
* Gabriel Siewert, 2023.11.29: Implemented The PlayForm
* Gabriel Siewert, 2023.11.29: Finilized PlayForm 
*/

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
using static System.Windows.Forms.LinkLabel;

namespace GSiewertQGame
{
    /// <summary>
    /// The PlayForm allows users to Play levels created in the DesignForm
    /// </summary>
    public partial class PlayForm : Form
    {
        // Tile constants
        private const int TILE_WIDTH = 75;
        private const int TILE_DISPLACMENT_X = 50;
        private const int TILE_DISPLACMENT_Y = 50;
        // File data constants
        private const int TILE_INFORMATION = 3, VALUE_LOCATION = 2, ROW_LOCATION = 0, COL_LOCATION = 1;
        // Tile value constants
        private const int NONE = 0, WALL = 1, RED_DOOR = 2, GREEN_DOOR = 3, RED_BOX = 4, GREEN_BOX = 5;
        QPictureBox[,] playBoard;

        QPictureBox selectedBox = null;
        List<QPictureBox> boxes = new List<QPictureBox>();

        private int boxesCount = 0;
        private int movesCount = 0;

        /// <summary>
        /// The default constructor the the DesignForm
        /// </summary>
        public PlayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the form is loaded the movement buttons are disabled
        /// </summary>
        /// <param name="sender"> Object that triggered the event </param>
        /// <param name="e"> Contains the event data </param>
        private void PlayForm_Load(object sender, EventArgs e)
        {
            btnDown.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            btnUp.Enabled = false;
        }

        /// <summary>
        /// Opens design level file and creates the level on the playboard and saves each tile into an array
        /// </summary>
        /// <param name="filename"> Design level file in device </param>
        private void LoadLevel(string filename)
        {
            int rows = 0;
            int cols = 0;
            int repeatCount = -1;
            string currLine = "";
            List<string> lines = new List<string>();
            try
            {
                StreamReader reader = new StreamReader(filename);
                rows = int.Parse(reader.ReadLine());
                cols = int.Parse(reader.ReadLine());

                playBoard = new QPictureBox[rows, cols];

                while (currLine != null)
                {
                    repeatCount++;
                    if (repeatCount == TILE_INFORMATION)
                    {
                        lines.Add(currLine);
                        currLine = "";
                        currLine = reader.ReadLine();
                        repeatCount = 0;
                    }
                    else
                    {
                        currLine += reader.ReadLine();
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < lines.Count; i++)
            {
                QPictureBox newTile = new QPictureBox();
                string row = lines[i][ROW_LOCATION].ToString(), col = lines[i][COL_LOCATION].ToString(), val = lines[i][VALUE_LOCATION].ToString();
                newTile.Value = int.Parse(val);
                playBoard[int.Parse(row), int.Parse(col)] = newTile;
            }
            for (int i = 0; i < playBoard.GetLength(0); i++)
            {
                for (int j = 0; j < playBoard.GetLength(1); j++)
                {
                    QPictureBox tile = new QPictureBox();
                    // Create tile to be added to the Play Board
                    playBoard[i, j].Size = new Size(TILE_WIDTH, TILE_WIDTH);
                    playBoard[i, j].Location = new Point((TILE_WIDTH * j) + TILE_DISPLACMENT_X, (TILE_WIDTH * i) + TILE_DISPLACMENT_Y);
                    playBoard[i, j].BorderStyle = BorderStyle.None;
                    // Assign Image + more data for boxes
                    switch (playBoard[i, j].Value)
                    {
                        case NONE:
                            playBoard[i, j].Visible = false;
                            break;
                        case WALL:
                            playBoard[i, j].Image = Properties.Resources.Wall;
                            break;
                        case RED_DOOR:
                            playBoard[i, j].Image = Properties.Resources.RedDoor;
                            break;
                        case GREEN_DOOR:
                            playBoard[i, j].Image = Properties.Resources.GreenDoor;
                            break;
                        case RED_BOX:
                            playBoard[i, j].Image = Properties.Resources.RedBox;
                            playBoard[i, j].Row = j;
                            playBoard[i, j].Col = i;
                            playBoard[i, j].Click += boxSelect_Click;
                            boxes.Add(playBoard[i, j]);
                            boxesCount++;
                            break;
                        case GREEN_BOX:
                            playBoard[i, j].Image = Properties.Resources.GreenBox;
                            playBoard[i, j].Row = j;
                            playBoard[i, j].Col = i;
                            playBoard[i, j].Click += boxSelect_Click;
                            boxes.Add(playBoard[i, j]);
                            boxesCount++;
                            break;
                        default:
                            break;
                    }
                    playBoard[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    playBoard[i, j] = playBoard[i, j];

                    // Add new tile to the board
                    Controls.Add(playBoard[i, j]);
                    // Update number of boxes text box
                    txtBoxes.Text = boxesCount.ToString();
                }
            }
        }

        /// <summary>
        /// Updated the border on clicked box and saves it as the currently selected box
        /// </summary>
        /// <param name="sender"> Object that triggered the event </param>
        /// <param name="e"> Contains the event data </param>
        private void boxSelect_Click(object sender, EventArgs e)
        {
            QPictureBox selectedTile = (QPictureBox)sender;
            // Resets all Boxes to have no border
            foreach (QPictureBox tile in boxes)
                tile.BorderStyle = BorderStyle.None;
            // Sets selected box to have a border and remebers it as selected box
            selectedTile.BorderStyle = BorderStyle.Fixed3D;
            selectedBox = selectedTile;
        }

        /// <summary>
        /// Opens load dialog and sends the filename to the LoadLevel method
        /// </summary>
        /// <param name="sender"> Object that triggered the event </param>
        /// <param name="e"> Contains the event data </param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgOpen.Filter = "Text files|*.txt|All files|*.*";
            DialogResult levelSelect = dlgOpen.ShowDialog();

            switch (levelSelect)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    if (playBoard != null)
                    {
                        ClearBoard();
                    }
                    btnDown.Enabled = true;
                    btnLeft.Enabled = true;
                    btnRight.Enabled = true;
                    btnUp.Enabled = true;
                    movesCount = 0;
                    boxesCount = 0;
                    txtMoves.Text = movesCount.ToString();
                    txtBoxes.Text = boxesCount.ToString();
                    LoadLevel(dlgOpen.FileName);
                    break;
                default:
                    break;

            }
        }

        /// <summary>
        /// Removes all tiles on board for next game to be loaded
        /// </summary>
        private void ClearBoard()
        {
            for (int i = 0; i < playBoard.GetLength(0); i++)
            {
                for (int j = 0; j < playBoard.GetLength(1); j++)
                {
                    playBoard[i, j].Visible = false;
                }
            }
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"> Object that triggered the event </param>
        /// <param name="e"> Contains the event data </param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Moves the box through every empty space in the designated direction and gets removed if
        /// it hits a door of the corrisponding colour
        /// </summary>
        /// <param name="sender"> Object that triggered the event </param>
        /// <param name="e"> Contains the event data </param>
        private void BoxMovement(object sender, EventArgs e)
        {
            // Tile selected check
            if (selectedBox == null)
            {
                MessageBox.Show("Select A Tile", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Button btnDirection = (Button)sender;
            
            int mvtMultiplier = 0;
            int tileIteration = 0;
            // values to remeber the previous spot of the box before movement
            int tempBoxRow = selectedBox.Row;
            int tempBoxCol = selectedBox.Col;
             
            bool mvtSwitch = true;
            bool rvmSwitch = false;

            // Box looks at the tile it will move and checks if it's an empty spot
            try
            {
                switch (btnDirection.Name)
                {
                    case "btnUp":
                        while (mvtSwitch)
                        {
                            tileIteration++;
                            if (SameBoxAndDoor(tileIteration, 0))
                            {
                                selectedBox.Visible = false;
                                boxes.Remove(selectedBox);
                                rvmSwitch = true;
                            }
                            if (playBoard[selectedBox.Col - tileIteration, selectedBox.Row].Value == NONE)
                            {
                                mvtMultiplier++;
                            }
                            else
                            {
                                if (tileIteration != 1)
                                    movesCount++;
                                mvtSwitch = false;
                            }
                        }
                        selectedBox.Top -= TILE_WIDTH * mvtMultiplier;
                        selectedBox.Col -= mvtMultiplier;
                        break;
                    case "btnDown":
                        while (mvtSwitch)
                        {
                            tileIteration++;
                            if (SameBoxAndDoor(-tileIteration, 0))
                            {
                                selectedBox.Visible = false;
                                boxes.Remove(selectedBox);
                                rvmSwitch = true;
                            }
                            if (playBoard[selectedBox.Col + tileIteration, selectedBox.Row].Value == NONE)
                            {
                                mvtMultiplier++;
                            }
                            else
                            {
                                if (tileIteration != 1)
                                    movesCount++;
                                mvtSwitch = false;
                            }
                        }
                        selectedBox.Top += TILE_WIDTH * mvtMultiplier;
                        selectedBox.Col += mvtMultiplier;
                        break;
                    case "btnRight":
                        while (mvtSwitch)
                        {
                            tileIteration++;
                            if (SameBoxAndDoor(0, -tileIteration))
                            {
                                selectedBox.Visible = false;
                                boxes.Remove(selectedBox);
                                rvmSwitch = true;
                            }
                            if (playBoard[selectedBox.Col, selectedBox.Row + tileIteration].Value == NONE)
                            {
                                mvtMultiplier++;
                            }
                            else
                            {
                                if (tileIteration != 1)
                                    movesCount++;
                                mvtSwitch = false;
                            }
                        }
                        selectedBox.Left += TILE_WIDTH * mvtMultiplier;
                        selectedBox.Row += mvtMultiplier;
                        break;
                    case "btnLeft":
                        while (mvtSwitch)
                        {
                            tileIteration++;
                            if (SameBoxAndDoor(0, tileIteration))
                            {
                                selectedBox.Visible = false;
                                boxes.Remove(selectedBox);
                                rvmSwitch = true;
                            }
                            if (playBoard[selectedBox.Col, selectedBox.Row - tileIteration].Value == NONE)
                            {
                                mvtMultiplier++;
                            }
                            else
                            {
                                if (tileIteration != 1)
                                    movesCount++;
                                mvtSwitch = false;
                            }
                        }
                        selectedBox.Left -= TILE_WIDTH * mvtMultiplier;
                        selectedBox.Row -= mvtMultiplier;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            QPictureBox emptyTile = playBoard[selectedBox.Col, selectedBox.Row];
            if (rvmSwitch == false)
            {
                playBoard[selectedBox.Col, selectedBox.Row] = selectedBox;
                playBoard[tempBoxCol, tempBoxRow] = emptyTile;
            }
            else
            {
                boxesCount--;
                txtBoxes.Text = boxesCount.ToString();
                playBoard[selectedBox.Col, selectedBox.Row] = emptyTile;
                playBoard[tempBoxCol, tempBoxRow] = emptyTile;
                selectedBox = null;
            }
            txtMoves.Text = movesCount.ToString();

            // Win check and reset
            if (boxesCount == 0)
            {
                MessageBox.Show("Game Complete\nCongratulations", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBoard();
                boxesCount = 0;
                movesCount = 0;
                txtBoxes.Text = boxesCount.ToString();
                txtMoves.Text = movesCount.ToString();
                btnDown.Enabled = false;
                btnLeft.Enabled = false;
                btnRight.Enabled = false;
                btnUp.Enabled = false;
            }
        }

        /// <summary>
        /// Checks if the ahead tile is a matching color door
        /// </summary>
        /// <param name="colIteration"> Vertiacl direction iteration </param>
        /// <param name="rowIteration"> Horizontal direction iteration </param>
        /// <returns></returns>
        private bool SameBoxAndDoor(int colIteration, int rowIteration)
        {
            if (playBoard[selectedBox.Col - colIteration, selectedBox.Row - rowIteration].Value == GREEN_DOOR && selectedBox.Value == GREEN_BOX)
                return true;
            else if (playBoard[selectedBox.Col - colIteration, selectedBox.Row - rowIteration].Value == RED_DOOR && selectedBox.Value == RED_BOX)
                return true;
            else
                return false;
        }
    }
}
