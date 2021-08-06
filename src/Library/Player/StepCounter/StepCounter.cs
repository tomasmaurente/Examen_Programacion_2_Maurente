using System.Collections.Generic;

/*
    SRP: Esta clase cumple con SRP ya que su unica razon de cambio es que si se quiere llevar la cuenta de una manera distinta, esta clase deberá ser modificada.

    OCP: Esta clase cumple con OCP ya que es independiente al resto del codigo a la hora de implementarse, es decir que no modifica el resto del codigo 
    a la hora de implementarse en otra clase. A esta tipo de clases se la llama clase componente, debido a que exiten para componer a otras, estas clases 
    se crean para asumir una responsabilidad y restarle una razon de cambio a la clase compuesta. Asi se  logra tambien que la clase compuesta pueda 
    obtener nuevas funcionalidades teniendo cambios minimos.
*/

namespace Library
{
    public class StepCounter
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