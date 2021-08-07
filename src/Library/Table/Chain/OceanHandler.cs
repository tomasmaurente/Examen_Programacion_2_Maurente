
/*
    SRP: Esta clase cumple con SRP ya que su unica resposabilidad es definir un handler. Cada handler contiene un IStep ejecutable. 
    
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
    public class OceanHandler : AbstractHandler
    {
        public OceanHandler()
        : base(new MountainHandler2(), Ocean.GetOcean())
        { }
    }
}