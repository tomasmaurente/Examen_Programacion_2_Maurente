 
/*
    SRP: Esta interfaz cumple con SRP ya que su unica responsabilidad es definir las operaciones necesarias para que un Step sea un Escenario.
    
    OCP: No se aplica.

    LSP: Esta interfaz cumple con LSP, aunque no se utilice en el codigo el tipo que define esta interfaz pdria ser utilizado para englovar todos los
    objetos subtipos que implementen esta interfaz.

    ISP: No se aplica.

    DIP: Esta clase cumple con DIP ya que no tiene dependencias.
*/

namespace Library
{
    public interface IScenary : IStep
    {
        public Point PointsOfVisit(int timesInStep);
    }
}