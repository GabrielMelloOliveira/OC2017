﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.Model
{
    public class Perfil
    {
        public Perfil()
        {
            Funcionalidades = new List<Funcionalidade>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Funcionalidade> Funcionalidades { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
