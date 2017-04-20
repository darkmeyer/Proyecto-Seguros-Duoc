﻿using Seguro.DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguro.Negocio
{
    public class CommonBC
    {
        private static SeguroEntities _modeloSeguro;

        public static SeguroEntities ModeloSeguro
        {
            get 
            { 
                if(_modeloSeguro == null)
                {
                    _modeloSeguro = new SeguroEntities();
                }
                return _modeloSeguro; 
            }
        }

        public CommonBC()
        {

        }
        
    }
}
