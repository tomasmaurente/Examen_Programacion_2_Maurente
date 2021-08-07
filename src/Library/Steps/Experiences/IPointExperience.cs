 
/*
    SRP: Esta interfaz cumple con SRP ya que su unica responsabilidad es definir las operaciones necesarias para que una Experiencia nueva devuelva
    Points como reward.
    
    OCP: No se aplica.
    
    LSP: Esta interfaz cumple con LSP, aunque no se utilice en el codigo el tipo que define esta interfaz pdria ser utilizado para englovar todos los
    objetos subtipos que implementen esta interfaz.

    ISP: No se aplica.

    DIP: Esta clase cumple con DIP ya que no tiene dependencias.
    
    EXPERT: No se aplica.

    POLYMORPHISM: No se aplica.

    CREATOR: No se aplica. 

    LEY DE DEMETER: No se aplica.
*/

namespace Library
{
    public interface IPointExperience : IStep
    {
        public Point SetPointReward(int value);
    }
}