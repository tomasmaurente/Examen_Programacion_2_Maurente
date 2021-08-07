using System.Collections.Generic;
using System.Linq;

/*
    SRP: Esta clase no cumple con SRP ya que tiene dos responsabilidades, definir el handler, y definir un StartHandler. Se rompe con el principio debido 
    a que no se puede resolver heredando, ni componiendo. Para situar una responsabilidad en una composicion (digamos IStartHandler) esta composicion 
    necesitaría saber informacion del handler que haria que este rompiera con su encapsulacion, lo mismo sucede a la hora de heredar.
    
    OCP: Esta clase cumple con OCP ya que la clase es extendida y no modificada.
    
    LSP: Esta clase cumple con LSP ya que en varias ocaciones es utilizada como parametro de tipo AbstractHandler.
    
    ISP: Esta clase cumple con ISP ya que todas la operaciones que define la interfaz son utilizadas por la clase.

    DIP: Esta clase cumple con DIP ya que depende solamente de abstracciones. Sus dependencias son con AbstractPlayer e IStep.
    
    EXPERT: No se aplica.

    POLYMORPHISM: No se aplica.

    CREATOR: Esta clase aplica el patron ya que crea Exepciones. Se justifica ya que por la logica escrita por el codigo esta clase sabe cuando debe crear
    un nuevo Exeption, siendo así una clase experta para crear instancias de otra. 

    LEY DE DEMETER: No se aplica.
*/

namespace Library
{
    public class StartHandler : AbstractHandler, IStartHandler
    {
        private bool canGetIn = true;
        private List<AbstractPlayer> listOfPlayers = new List<AbstractPlayer>();
        public StartHandler()
        : base(new FarmHandler(), null)
        { }
        public void GetInTable(AbstractPlayer player)
        {
            if (this.IsAvailable())
            {
                this.players.Add(player);
                this.listOfPlayers.Add(player);
            }
            else
            {
                this.canGetIn = false;
                throw new GameIsAlreadyStartedException();
            }
        }
        public List<AbstractPlayer> GetPlayers()
        {
            return listOfPlayers;
        }
        public override bool IsAvailable()
        {
            if (canGetIn)
            {
                if (this.players.Count < 5)
                {
                    return true;
                }
                throw new TooManyPlayersInTableExeption();
            }
            return false;
        }
        public override void ExecuteStep(AbstractPlayer player)
        {
            if (this.players.Contains(player))
            {
                this.canGetIn = false;
            }
            else
            {
                this.next.ExecuteStep(player);
            }
        }
        public override void MovePlayer(AbstractPlayer player, int spotsToMove, bool playerAlreadyFound)
        {
            if (spotsToMove >= 0)
            {
                if (this.players.Contains(player))
                {
                    this.players.Remove(player);
                    this.next.MovePlayer(player, spotsToMove - 1, true);
                    this.canGetIn = false;
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
        public List<AbstractPlayer> GetPodium()
        {
            return this.listOfPlayers.OrderBy(p => p.TotalPoints().Value).ThenBy(p => p.TotalCoins().Value).ToList();
        }
    }
}