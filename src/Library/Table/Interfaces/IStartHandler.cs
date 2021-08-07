using System.Collections.Generic;

/*
    SRP: Esta interfaz cumple con SRP ya que su unica responsabilidad es definir las operaciones necesarias para que un handler pueda ser un hanlder 
    de entrada al juego. Si se imlementara esta interfaz en un handler a la mitad del tablero se podría jugar desde ese handler en adelante.

    OCP: No se aplica.

    LSP: No se aplica.

    ISP: Esta interfaz cumple con ISP ya que todas la operaciones que define son utilizadas por la clase que la implementa.

    DIP: Esta interfaz cumple con DIP ya que no tiene dependencias.
    
    EXPERT: No se aplica.

    POLYMORPHISM: No se aplica.

    CREATOR: No se aplica.

    LEY DE DEMETER: No se aplica.

    COHESION: La cohesion de esta interfaz es ALTA ya que solo existe para definir las operaciones que debe implementar un handler iniciador de tablero.

    ACOPLAMIENTO: No se aplica.
*/

/// <summary>
/// Esta interfaz se define para que el handler que la implemente pueda devolver el resultado del juego y tambien unir jugadores al tablero.
/// </summary>

namespace Library
{
    public interface IStartHandler
    {
        public void GetInTable(AbstractPlayer player);
        public List<AbstractPlayer> GetPodium();
    }
}