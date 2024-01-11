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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSiewertQGame
{
    /// <summary>
    /// An inherited control of the PictureBox with added value to represent which item image is in the PictureBox
    /// </summary>
    public class QPictureBox : PictureBox
    {
        private int value;
        private int col;
        private int row;
        public int Value { get => value; set => this.value = value; }
        public int Col { get => col; set => col = value; }
        public int Row { get => row; set => row = value; }
    }
}
