using OopLab.OopLab.BLL.Accounts;
using OopLab.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab.UI
{
    public class ShowPlayerByIdUI : IUserInterface
    {
        IGameAccountService _accountService;
        int _id;
        public ShowPlayerByIdUI(IGameAccountService accountService, int id)
        {
            _accountService = accountService;
            _id = id;
        }

        public void Action()
        {
            GameAccount acc = _accountService.GetById(_id);
            Console.WriteLine(acc.GetStats()); 
        }
    }
}
