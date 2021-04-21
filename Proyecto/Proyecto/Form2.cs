using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class NombrePlayer : Form
    {
        String nombrep;
        
        public NombrePlayer()
        {
            InitializeComponent();
           ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombrep = NamePlayer.Text;
           // MessageBox.Show(nombrep);
            this.Close();
          
        }
        public String DevNombre()
        {
            return nombrep;
        }
        
    }
}
