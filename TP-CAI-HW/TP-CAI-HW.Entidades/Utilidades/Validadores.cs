using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TP_CAI_HW.Entidades
{
    public class Validadores
    {
        public static bool IsNullOrEmpy(string Valor)
        {
            return !(String.IsNullOrEmpty(Valor));
        }

        public static void ValidarComboBox(ComboBox cboBox, Label lbl)
        {
            if (cboBox.SelectedIndex == -1)
            {
                throw new Exception("Seleccione un valor para el campo " + lbl.Text);
            }

        }
        public static double StringToDouble(string Valor)
        {
            bool ValidacionOk = false;
            double DoubleOk;
            do
            {
                ValidacionOk = double.TryParse(Valor, out DoubleOk);
                if (!ValidacionOk)
                {
                    throw new Exception("El valor debe ser un número.");
                }
            } while (!ValidacionOk);

            return DoubleOk;

        }

        public static int StringToInt(string Valor)
        {
            bool ValidacionOk = false;
            int IntOk;
            do
            {
                ValidacionOk = int.TryParse(Valor, out IntOk);
                if (!ValidacionOk)
                {
                    throw new Exception("El valor debe ser un número.");
                }
            } while (!ValidacionOk);

            return IntOk;

        }
    }
}