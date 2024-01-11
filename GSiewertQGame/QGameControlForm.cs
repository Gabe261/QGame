/* GSiewertQGame.cs
* Assignment 2
* Revision History
* Gabriel Siewert, 2023.10.30: Created Program
* Gabriel Siewert, 2023.11.05: Finilized Project
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSiewertQGame
{
    /// <summary>
    /// Opening form that allows user to design a new level or open and play a level
    /// </summary>
    public partial class QGameControlForm : Form
    {
        /// <summary>
        /// Control Form's default constructor
        /// </summary>
        public QGameControlForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exits the program
        /// </summary>
        /// <param name="sender"> Exit button information </param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Creates a new DesignForm and displays it to user
        /// </summary>
        /// <param name="sender"> Senders button information </param>
        /// <param name="e"> Contains the event data </param>
        private void btnDesign_Click(object sender, EventArgs e)
        {
            DesignForm newForm = new DesignForm();
            newForm.Show();
        }
        /// <summary>
        /// Creates a new PlayForm and displays it to user
        /// </summary>
        /// <param name="sender"> Senders button information </param>
        /// <param name="e"> Contains the event data </param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm newForm = new PlayForm();
            newForm.Show();
        }
    }
}
