
/*
    SRP: Esta clase cumple con SRP ya que su unica resposabilidad es definir un FinalHandler y sus metodos particulares.
    
    OCP: No se aplica.

    LSP: Esta clase cumple con LSP ya que en varias ocaciones es utilizada como parametro de tipo AbstractHandler.

    ISP: No se aplica.

    DIP: Esta clase cumple con DIP ya que depende solamente de abstracciones. Sus dependencias son con AbstractPlayer e IStep.
    
    EXPERT: No se aplica.

    POLYMORPHISM: No se aplica.

    CREATOR: Esta clase aplica el patron ya que crea Exepciones. Se justifica ya que por la logica escrita por el codigo esta clase sabe cuando debe crear
    un nuevo Exeption, siendo así una clase experta para crear instancias de otra. 

    LEY DE DEMETER: No se aplica.

    COHESION: La cohesion de esta clase es ALTA ya que solo existe para definir un Handler.

    ACOPLAMIENTO: No se aplica.
*/

namespace Library
{
    public class FinalHandler : AbstractHandler
    {
        public FinalHandler()
        : base(null, null)
        { }

        public override void ReceivePlayer(AbstractPlayer player)
        {
            this.players.Add(player);
        }
        public override bool IsAvailable()
        {
            return true;
        }
        // Este metodo se sobreescribe ya que no hay un paso siguiente.
        public override AbstractPlayer GetLastPlayer()
        {
            throw new AlreadyFinishedException();
        }
        // Este metodo se sobreescribe ya que no hay un paso siguiente.
        public override void MovePlayer(AbstractPlayer player, int spotsToMove, bool playerAlreadyFound)
        {
            if (spotsToMove > 0)
            {
                this.ReceivePlayer(player);
                throw new EndOfTheRoadException();
            }
            else
            {
                this.ReceivePlayer(player);
            }
        }
        // Este metodo se sobreescribe ya que no hay un paso siguiente ni un step para ejecutar.
        public override void ExecuteStep(AbstractPlayer player)
        {
            return;
        }
    }
}