using System.Collections.Generic;

/*
    SRP: Esta interfaz cumple con SRP ya que su unica responsabilidad es definir las operaciones necesarias para que un handler pueda ser un hanlder 
    de entrada al juego. Si se imlementara esta interfaz en un handler a la mitad del tablero se podría jugar desde ese handler en adelante.
*/

namespace Library
{
    public interface IStartHandler
    {
        public void GetInTable(AbstractPlayer player);
        public List<AbstractPlayer> GetPodium();
    }
}