using System.Collections.Generic;

/*
    SRP: Esta clase cumple con SRP ya que su unica razon de cambio es que si se quiere llevar la cuenta de una manera distinta, esta clase deberá ser modificada.

    OCP: Esta clase cumple con OCP ya que es independiente al resto del codigo a la hora de implementarse, es decir que no modifica el resto del codigo 
    a la hora de implementarse en otra clase. A esta tipo de clases se la llama clase componente, debido a que exiten para componer a otras, estas clases 
    se crean para asumir una responsabilidad y restarle una razon de cambio a la clase compuesta. Asi se  logra tambien que la clase compuesta pueda 
    obtener nuevas funcionalidades teniendo cambios minimos.

    LSP: No se aplica.

    ISP: esta clase cumple ISP ya que define metodos que la clase compuesta usara en su totalidad.

    DIP: Esta clase cumple con DIP ya que no depende de ninguna clase de bajo nivel. Ademas esta implementa IStepCounter para permitir que AbstractPlayer
    no dependa de StepCounter sino de la Interface IStepCounter.

    EXPERT: Esta clase es la experta en conocer el historial de lugares visitados del jugador.

    POLYMORPHISM: No se aplica.

    CREATOR: No se aplica. 

    LEY DE DEMETER: No se aplica.

    COHESION: La cohesion de esta clase es ALTA ya que solo existe para llevar un registro de los steps que el objeto compuesto visite.

    ACOPLAMIENTO: Esta clase tiene BAJO acoplamiento ya que hace solo depende de abstracciones.
*/

namespace Library
{
    public class StepCounter : IStepCounter
    {
        private Dictionary<IStep, int> stepsCounter = new Dictionary<IStep, int>();
        public int GetStepInformation(IStep step)
        {
            if (step != null)
            {
                if (!(stepsCounter.ContainsKey(step)))
                {
                    stepsCounter.Add(step, 1);
                }
                return stepsCounter[step];
            }
            return 0;
        }

        public void ReceiveStepConfirmation(IStep step)
        {
            if (step != null)
            {
                if (!(stepsCounter.ContainsKey(step)))
                {
                    stepsCounter.Add(step, 1);
                }
                else
                {
                    stepsCounter[step] += 1;
                }
            }
            return;
        }
    }
}