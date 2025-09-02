// See https://aka.ms/new-console-template for more information
using Banking;

Account aact123 = new Account();
aact123.Balance = 67000;
Console.WriteLine($" balance is : {aact123.Balance}");
AccountListner.sendEmail();
AccountOperation agent = new AccountOperation(AccountListner.blockAccount);
agent += AccountListner.sendEmail;
agent();
