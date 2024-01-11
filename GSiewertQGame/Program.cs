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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSiewertQGame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QGameControlForm());
        }
    }
}
