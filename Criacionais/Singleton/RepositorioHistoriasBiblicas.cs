using System;
using System.Collections.Generic;

namespace Criacionais.Singleton
{
    public class RepositorioHistoriasBiblicas
    {
        private static RepositorioHistoriasBiblicas? _instancia;
        private static readonly object _lock = new object();

        private readonly List<HistoriaBiblica> _historias = new List<HistoriaBiblica>();

        private RepositorioHistoriasBiblicas() { }

        public static RepositorioHistoriasBiblicas Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (_lock)
                    {
                        if (_instancia == null)
                            _instancia = new RepositorioHistoriasBiblicas();
                    }
                }
                return _instancia;
            }
        }

        public void Adicionar(HistoriaBiblica historia)
        {
            _historias.Add(historia);
        }

        public IEnumerable<HistoriaBiblica> Listar()
        {
            return _historias;
        }

        public HistoriaBiblica? BuscarPorTitulo(string titulo)
        {
            return _historias.Find(h => h.Titulo == titulo);
        }
    }
}