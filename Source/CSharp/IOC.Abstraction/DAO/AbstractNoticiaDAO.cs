﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IOC.FW.Core;
using IOC.Model;
using IOC.FW.Core.Base;

namespace IOC.Abstraction.DAO
{
    public abstract class AbstractNoticiaDAO
        : BaseRepository<Noticia>
    {
        public AbstractNoticiaDAO(string connectionString = null)
            : base()
        { }

        public abstract bool Teste(string Titulo);
    }
}