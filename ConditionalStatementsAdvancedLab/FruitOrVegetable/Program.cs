var fruitOrVeggie = Console.ReadLine();

Console.WriteLine((fruitOrVeggie == "banana" || fruitOrVeggie == "apple" ||
                   fruitOrVeggie == "kiwi" || fruitOrVeggie == "cherry" ||
                   fruitOrVeggie == "lemon" || fruitOrVeggie == "grapes") ? "fruit" :
                 ((fruitOrVeggie == "tomato" || fruitOrVeggie == "cucumber" ||
                   fruitOrVeggie == "pepper" || fruitOrVeggie == "carrot") ? "vegetable" :
                  "unknown"));