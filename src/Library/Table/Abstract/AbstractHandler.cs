using System.Collections.Generic;

/*
    SRP: Esta clase cumple con SRP ya que su unica razon de cambio es que si se quisiece agregar un comando al juego como por ejemplo mover para atras. 
    
    OCP: Esta clase cumple con OCP ya que esta abierta a la extencion, StartHandler es un ejemplo. Otro ejemplo es, si se quisiera implementar un nuevo 
    handler, bastaría con crear una clase que defina el handler, heredar esta clase y agragarla a la cadena.

    LSP: Esta clase cumple con LSP ya que en varias oaciones en el codigo se utiliza el tipo que define para englovar todos los subtipos que la suceden.

    ISP: No se aplica.

    DIP: Esta clase cumple con DIP ya que depende solamente de abstracciones. Sus dependencias son con AbstractPlayer e IStep.
    
    EXPERT: No se aplica.

    POLYMORPHISM: No se aplica.

    CREATOR: Esta clase aplica el patron ya que crea Exepciones. Se justifica ya que por la logica escrita por el codigo esta clase sabe cuando debe crear
    un nuevo Exeption, siendo así una clase experta para crear instancias de otra. 

    LEY DE DEMETER: No se aplica.

    COHESION: La cohesion de esta clase es BAJA ya que esta clase tiene muchas operaciones, mas es preferible mantener una cohesion baja y cumplir con
    el encapsulamiento.

    ACOPLAMIENTO: Esta clase tiene BAJO acoplamiento ya que hace solo depende de abstracciones, y ademas genera BAJO acoplamiento ya que a la hora 
    de querer incluir otro Step al tablero solo se debe crear un handler, heredar esta clase y sumarla a la cadena, haciend cambios minimos en el 
    resto del codigo.
*/

/// <summary>
/// Esta clase es el modelo de los handlers, define todos los metodos que un handler necesita para que el player pueda jugar.
/// </summary>

namespace Library
{
    public abstract class AbstractHandler
    {
        protected AbstractHandler next;
        protected List<AbstractPlayer> players = new List<AbstractPlayer>();
        protected IStep step;
        // En todos los handlers se debe definir que step ejecutaran y cual es el proximo handler.
        protected AbstractHandler(AbstractHandler next, IStep step)
        {
            this.next = next;
            this.step = step;
        }
        // Este metodo checkea que se pueda aceptar a un nuevo player en el handler y luego lo agrega dependiendo el resultado.
        public virtual void ReceivePlayer(AbstractPlayer player)
        {
            if (this.IsAvailable())
            {
                this.players.Add(player);
            }
            else
            {
                throw new IsNotAvailableException();
            }
        }
        // Este metodo debuelve un booleano dependiendode si hay espacio o no.
        public virtual bool IsAvailable()
        {
            return this.players.Count < 2;
        }
        // Este metodo retorna el primer player que encuentre en su lista, si no tiene le pregunta al hanlder siguiente.
        public virtual AbstractPlayer GetLastPlayer()
        {
            if (players.Count > 0)
            {
                return players[0];
            }
            else
            {
                return this.next.GetLastPlayer();
            }
        }
        // Este metodo mueve el player a traves de los handlers, un player se le pasa por parametro, si este estalo manda al siguiente llevando una
        // cuenta de la cantidad de saltos. No permite movimientos hacia atras-.
        public virtual void MovePlayer(AbstractPlayer player, int spotsToMove, bool playerAlreadyFound)
        {
            if (spotsToMove >= 0)
            {
                if (this.players.Contains(player))
                {
                    this.players.Remove(player);
                    this.next.MovePlayer(player, spotsToMove - 1, true);
                }
                else
                {
                    if (playerAlreadyFound)
                    {
                        if (spotsToMove == 0)
                        {
                            this.ReceivePlayer(player);
                            return;
                        }
                        this.next.MovePlayer(player, spotsToMove - 1, true);
                    }
                    else
                    {
                        this.next.MovePlayer(player, spotsToMove, false);
                    }
                }
            }
            else
            {
                throw new JustMoveFowardExeption();
            }
        }
        // Este metodo checkea si el player esta en su lista, si lo esta, hace que el player ejecute el step del handler, si no, le pregunta al
        // siguiente handler.
        public virtual void ExecuteStep(AbstractPlayer player)
        {
            if (this.players.Contains(player))
            {
                player.ExecuteStep(step);
            }
            else
            {
                this.next.ExecuteStep(player);
            }
        }
    }
}