using OopLab.DB.Entity;
using OopLab.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab.UI
{
    public class StarterChooseUI : IUserInterface
    {
        ChooseGameUI gameUI;
        ChoosePlayerUI playerUI;
        PlayGameUI playGameUI;
        ShowPlayerUI showPlayerUI;
        StartGameUI startGameUI;
        IGameAccountService _accountService;
        IGameService _gameService;
        public StarterChooseUI(IGameAccountService accountService, IGameService gameService) 
        {
            _accountService= accountService;
            _gameService= gameService;
            gameUI = new ChooseGameUI(_gameService, _accountService);
            playerUI = new ChoosePlayerUI(_accountService);
            playGameUI = new PlayGameUI(_accountService, _gameService);
            showPlayerUI = new ShowPlayerUI(_accountService);
            startGameUI = new StartGameUI(_accountService, _gameService);
        }
        public void Action()
        {
            Console.WriteLine("1) почати гру;");
            Console.WriteLine("2) вивести всіх гавців;");
            Console.WriteLine("3) вивести гравця по айді;\n");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp == 1)
            {
                playerUI.Action();
                playerUI.Action();
                gameUI.Action();
                startGameUI.Action();
                playGameUI.Action();
            }
            else if (temp == 2)
            {
                showPlayerUI.Action();
            }
            else if (temp == 3)
            {
                Console.Write("Id:");
                int id = Convert.ToInt32(Console.ReadLine());
                var showPlayerByIdUI = new ShowPlayerByIdUI(_accountService, id);
                showPlayerByIdUI.Action();
            }
            else
            {
                Console.WriteLine("\nВведене некоректне значення!");
                Action();
            }
            
            Action();
            
        }
    }
}
