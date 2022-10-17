//string[] snacks = { "sushi", "pizza", "burger", "asian", "chicken" };

//Random rnd = new Random();

//int RandomIndex = rnd.Next(0, snacks.Length);

//Console.WriteLine($"Tonight we are going to eat {snacks[RandomIndex]}.");

string[] colors = { "red", "green", "blue", "pink", "yellow" };
Random rnd = new Random();

int randomColor = colors[rnd.Next(0, colors)];

Console.WriteLine($"You should wear {colors} today.");