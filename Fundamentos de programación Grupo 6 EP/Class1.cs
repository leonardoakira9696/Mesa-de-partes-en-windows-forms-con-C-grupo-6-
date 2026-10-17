using System;
using System.Collections.Generic;
using System.Text;


namespace Fundamentos_de_programación_Grupo_6_EP
{
    public class Expediente
    {
        public string Codigo { get; set; } = string.Empty;
        public string Remitente { get; set; } = string.Empty;
        public string TipoDocumento { get; set; } = string.Empty;
        public string Asunto { get; set; } = string.Empty;
        public DateTime FechaRecepcion { get; set; }
        public string Estado { get; set; } = string.Empty;
    }
}

