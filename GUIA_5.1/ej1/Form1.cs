using ej1.Models;
namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string patente = tbPatente.Text;
            if(rbString.Checked )
            {
                Patente pat = new Patente(patente);
                switch (pat.DeterminarTipo())
                {
                    case 0: lsbVer.Items.Add("Hasta 2016");break;
                    case 1:lsbVer.Items.Add("Desde 2016");break;
                    case 2:lsbVer.Items.Add("Moto"); break;
                    case 3:lsbVer.Items.Add("Acoplado");break;
                    default:lsbVer.Items.Add("No reconocido"); break; 
                }
            }
            else if (rbRegex.Checked )
            {
                PatenteRegex pat = new PatenteRegex(patente);
                switch (pat.DeterminarTipo())
                {
                    case 0: lsbVer.Items.Add("Hasta 2016"); break;
                    case 1: lsbVer.Items.Add("Desde 2016"); break;
                    case 2: lsbVer.Items.Add("Moto"); break;
                    case 3: lsbVer.Items.Add("Acoplado"); break;
                    default: lsbVer.Items.Add("No reconocido"); break;
                }
            }
        }
    }
}
