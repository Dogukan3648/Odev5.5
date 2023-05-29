
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Id = 1;
            player.NationalityId = "11111111";
            player.FirstName = "Doğukan";
            player.LastName = "Bozkır";
            player.DateOfBirth = new DateTime(1996, 06, 05);
            player.UserName = "username";

            Player  player1 = new Player();
            player1.Id = 1;
            player1.NationalityId = "11111111";
            player1.FirstName = "Berivan";
            player1.LastName = "Tosun";
            player1.DateOfBirth = new DateTime(2000, 09, 19);
            player1.UserName = "username1";


            Offer offer = new Offer();
            offer.Id = 1;
            offer.OfferName = "Yaz Sezonu";


            Game game = new Game();
            game.Id = 1;
            game.GameName = "LOL";
            Game game1 = new Game();
            game1.Id = 2;
            game.GameName = "Counter Strike";




            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player);
            playerManager.Delete(player1);

            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Delete(game1);

            OfferManager offerManager = new OfferManager();
            offerManager.Add(offer);





            Console.ReadLine();


        }
    }
}