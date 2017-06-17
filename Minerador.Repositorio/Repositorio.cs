using System;

namespace Minerador.Repositorio
{
    public class Repositorio<T> where T : class, new()
    {
        private static readonly Lazy<T> _instancia = new Lazy<T>(() => new T());

        public static T Instancia => _instancia.Value;
    }
}
