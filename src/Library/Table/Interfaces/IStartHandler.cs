using System.Collections.Generic;

namespace Library
{
    public interface IStartHandler
    {
        public void GetInTable(AbstractPlayer player);
        public List<AbstractPlayer> GetPlayers();
    }
}