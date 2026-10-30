namespace Proyec.ListaCircular
{
    // OPERACIÓN 4 - Un NODO es una categoría de productos (Gaseosas, Papas...)
    public class NodoCategoria
    {
        public string Categoria;
        public NodoCategoria Siguiente;   // Categoría que se revisa después

        public NodoCategoria(string categoria)
        {
            this.Categoria = categoria;
            this.Siguiente = null;
        }
    }
}
