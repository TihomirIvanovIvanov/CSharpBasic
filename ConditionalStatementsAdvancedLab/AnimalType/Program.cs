var animal = Console.ReadLine();

Console.WriteLine(animal == "dog" ? "mammal" :
                 (animal == "crocodile" ? "reptile" :
                  animal == "tortoise" ? "reptile" :
                  animal == "snake" ? "reptile" :
                  "unknown"));