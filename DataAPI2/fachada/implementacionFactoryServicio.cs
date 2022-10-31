using DataAPI2.fachada.implementacion;
using DataAPI2.fachada.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI2.fachada
{
    internal class implementacionFactoryServicio : factoryServicio
    {
        public override iServicio crearServicio()
        {
            return new bancoServicio();
        }
    }
}
