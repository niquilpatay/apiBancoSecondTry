using DataAPI2.fachada.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI2.fachada
{
    abstract class factoryServicio
    {
        public abstract iServicio crearServicio();
    }
}
