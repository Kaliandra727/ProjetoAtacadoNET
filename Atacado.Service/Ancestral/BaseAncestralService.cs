using Atacado.DAL.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Ancestral
{
    public abstract class BaseAncestralSrv<T> where T : class
    {
        protected BaseAncestralDAO<T> dao;
    }
}