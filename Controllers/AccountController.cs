using InterestCalculatorMVC.Models;

using Microsoft.AspNetCore.Mvc;

namespace InterestCalculatorMVC.Controllers {

    public class AccountController : Controller {

        private Account account = new Account {
            Balance = 100, Rate = 0, Months = 0, Interest = 0
        };

        public IActionResult Index() {
            return View(account);
        }
        [HttpPost]
        public IActionResult Display(Account acct) {
            acct.Interest = acct.Balance * (acct.Rate / 12) * acct.Months;
            acct.Balance += acct.Interest;
            return View(acct);
        }
    }
}
