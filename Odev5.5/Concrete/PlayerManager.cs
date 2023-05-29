using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    internal class PlayerManager : IPlayerService
    {


        public void Add(Player player)
        {
            Console.WriteLine(player.FirstName + " Adlı Oyuncu Eklendi");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " Adlı Oyunce Silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " Adlı Oyuncu Güncellendi");
        }
    }
}