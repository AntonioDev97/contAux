using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContAux.view
{
    public partial class MenuContaux : Form
    {
        private static String[] tab = { "0.01|496.07|0.00|1.92", "497.08|4210.41|9.52|6.40", "4210.42|7339.42|247.24|10.88",
                                        "7339.43|8601.50|594.21|16.00","8601.51|10298.35|786.54|17.92", "10298.36|20770.29|1090.61|21.36",
                                        "20770.30|32736.83|3327.42|23.52","32736.84|62500.00|6141.95|30.00","62500.01|83333.33|15070.90|32.00",
                                        "83333.34|250000.00|21737.57|34.00","250000.00|none|78404.23|35.00"};
        public MenuContaux()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultureMx = new System.Globalization.CultureInfo("es-mx");
            Thread.CurrentThread.CurrentCulture = cultureMx;
            Double Num;

            bool isNum = Double.TryParse(txtSueldo.Text.Trim(), out Num);
            if (isNum && Convert.ToDouble(txtSueldo.Text) > 0.00) {
                //MessageBox.Show("Verifique el sueldo introducido e intente de nuevo", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Double sueldo = Convert.ToDouble(txtSueldo.Text);
                foreach (String ind in tab)
                {
                    String[] row = ind.Split('|');
                    Double limiteInferior = Convert.ToDouble(row[0]);
                    Double limiteSup = 0;
                    Boolean lim = Double.TryParse(row[1], out limiteSup);
                    Double porcentaje = Convert.ToDouble(row[3]);
                    Double couta = Convert.ToDouble(row[2]);
                    if (lim)
                    {
                        if (sueldo >= limiteInferior && sueldo <= limiteSup)
                        {
                            lblSueldo.Text = "$" + sueldo;
                            lblLimite.Text = "$" + row[0] + " - " + "$" + row[1];
                            Double bas = sueldo - limiteInferior;
                            Double per = (bas * porcentaje) / 100;
                            Double isr = per + couta;
                            lblISPT.Text = "$" + isr;
                            lblNeto.Text = "$" + (sueldo - isr);

                            return;
                        }
                    }
                    else {
                        lblSueldo.Text = "$" + sueldo;
                        lblLimite.Text = "$" + row[0] + " - " + "$" + row[1];
                        Double bas = sueldo - limiteInferior;
                        Double per = (bas * porcentaje) / 100;
                        Double isr = per + couta;
                        lblISPT.Text = "$" + isr;
                        lblNeto.Text = "$" + (sueldo - isr);

                        return;

                    }

                }
            }
            else
                MessageBox.Show("Verifique el sueldo introducido e intente de nuevo", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
