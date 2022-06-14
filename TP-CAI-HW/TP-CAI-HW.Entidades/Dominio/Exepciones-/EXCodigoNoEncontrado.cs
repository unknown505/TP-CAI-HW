using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI_HW.Entidades.Dominio;

namespace TP_CAI_HW.Entidades.Dominio.Exepciones_
{
    public class EXCodigoNoEncontrado : Exception
    {
        public EXCodigoNoEncontrado(int Id) : base(String.Format("El ID :"+ Id +" no se ha encontrado."))
        {

        }
    }
}
