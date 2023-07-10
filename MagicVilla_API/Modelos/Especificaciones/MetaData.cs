﻿using System.Security.Principal;

namespace MagicVilla_API.Modelos.Especificaciones
{
    public class MetaData
    {
        public int TotalPages { get; set; }
        public int PageSize { get; set; }

        public int TotalCount { get; set; } // Total de Registros
    }
}
