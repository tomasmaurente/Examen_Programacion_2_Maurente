using System.Collections.Generic;
 
/*
    SRP: Esta interfaz cumple con SRP ya que su unica responsabilidad es definir las operaciones necesarias que debe tener Step.
    
*/

namespace Library
{
    public interface IStep
    {
        public void Execute(int timesInStep, ref List<AbstractReward> rewards);
    }
}