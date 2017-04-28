using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class ConsultarReserva : Form
    {
        public ConsultarReserva()
        {
            InitializeComponent();
        }

        private void ConsultarReserva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pousadaDataSet4.Reservas' table. You can move, or remove it, as needed.
            this.reservasTableAdapter1.Fill(this.pousadaDataSet4.Reservas);


        }
    }
}
