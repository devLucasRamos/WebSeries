using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSeries.Interfaces;

namespace WebSeries.Entity
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie entidade)
        {
            throw new NotImplementedException();
        }
        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }
        public void Inserir(Serie entidade)
        {
            throw new NotImplementedException();
        }
        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Serie RetornaPorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
