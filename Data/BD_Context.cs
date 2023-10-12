using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Catalogo.Data
{
    public class BD_Context
    {
        public BD_Context(string valor) =>Conexion=valor;

        public string Conexion{get;}
        
    }
} 