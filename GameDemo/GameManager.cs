using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    class GameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "Oyun silindi. ");
        }

        public void Save(Game game)
        {
            Console.WriteLine(game.GameName + "Oyun kaydedildi. ");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "Oyun güncellendi. ");
        }
    }
}
