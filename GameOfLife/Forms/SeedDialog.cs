

using System.Windows.Forms;

namespace GameOfLife
{
    public partial class SeedDialog : Form
    {
        
        public SeedDialog()
        {
            InitializeComponent();
        }

        #region << Properties >>
        
        public int Seed
        {
            get
            {
                return (int)seedNumericUpDown.Value;
            }
            set
            {
                seedNumericUpDown.Value = value;
            }
        }
        #endregion
    }

}

