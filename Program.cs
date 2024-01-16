var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Random rnd = new Random();

app.MapGet("/", () => {
    // simulate light work
    int hash = 0;
    int it = rnd.Next(1000);
    for (int i = 0; i < it; ++i) {
        hash ^= rnd.Next(1 << 20);
    }
    return "Hash is " + hash + "\n";
});

app.Run();
