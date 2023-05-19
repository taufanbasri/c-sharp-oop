using Classes;

var account = new BankAccount("Taufan Prasetyo", 1_000_000);

System.Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");