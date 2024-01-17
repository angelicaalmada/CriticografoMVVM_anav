using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CriticografoMVVM_anav.ViewModel
{
    class VMpatron : BaseViewModel
    {
        #region VARIABLES
        private string nombre;
        private string MsjResult;
        private bool generoHombre;
        private bool generoMujer;
        private bool alto;
        private bool feo;
        private bool listo;
        private bool raro;
        private bool extravagante;
        private bool grande;
        #endregion
        #region OBJETOS
       public string Nombre 
        {
        get { return nombre; } 
        set {SetValue(ref nombre, value); }
        }
        public string msjResult
        {
            get { return MsjResult; }
            set { SetValue(ref MsjResult, value); }
        }
        public bool GeneroHombre
        {
            get { return generoHombre;}
            set { SetValue(ref generoHombre, value); }
        }
        public bool GeneroMujer
        {
            get { return generoMujer;}
            set { SetValue(ref generoMujer, value);}
        }
        public bool Alto
        {
            get { return alto; }
            set { SetValue(ref alto, value);}
        }
        public bool Feo
        {
            get { return feo; }
            set { SetValue(ref feo, value); }
        }
        public bool Listo
        {
            get { return listo; }
            set { SetValue(ref listo, value); }
        }
        public bool Raro
        {
            get { return raro; }
            set { SetValue(ref raro, value); }
        }
        public bool Extravagante
        {
            get { return extravagante; }
            set { SetValue(ref extravagante, value); }
        }
        public bool Grande
        {
            get { return grande; }
            set { SetValue(ref grande, value); }
        }

        #endregion
        #region PROCESOS
        public ICommand CalcularResultadosCommand => new Command(CalcularResultados);
        public void CalcularResultados()
        {
            
            string opcion = "";

            if (generoHombre)
            {
                if (Alto)
                {
                    opcion += " ALTO,";
                }

                if (Feo)
                {
                    opcion += " FEO,";
                }

                if (Listo)
                {
                    opcion += " LISTO,";
                }

                if (Raro)
                {
                    opcion += " RARO,";
                }

                if (Extravagante)
                {
                    opcion += " EXTRAVAGANTE,";
                }

                if (Grande)
                {
                    opcion += " GRANDE,";
                }
            }

            else if(generoMujer)
            {
                if (Alto)
                {
                    opcion += " ALTA,";
                }

                if (Feo)
                {
                    opcion += " FEA,";
                }

                if (Listo)
                {
                    opcion += " LISTA,";
                }

                if (Raro)
                {
                    opcion += " RARA,";
                }

                if (Extravagante)
                {
                    opcion += " EXTRAVAGANTE,";
                }

                if (Grande)
                {
                    opcion += " GRANDE,";
                }
            }

            string genero = generoHombre ? "Hombre" : generoMujer ? "Mujer" : "";
            string mensaje = $"{nombre} es {genero}";
            if (!string.IsNullOrWhiteSpace(opcion))
            {
                opcion = opcion.TrimEnd(',');
                int coma = opcion.LastIndexOf(",");
                if (coma > 0)
                {
                    mensaje += $" y es {opcion.Substring(0, coma)} y {opcion.Substring(coma + 1)}.";
                }
            }

            MsjResult = mensaje;
        }
        #endregion

    }
}
