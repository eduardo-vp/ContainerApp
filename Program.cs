var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Random rnd = new Random();

app.MapGet("/", () => {
    // simulate light work
    int sum = 0;
    int it = rnd.Next(1000);
    for (int i = 0; i < it; ++i) {
        sum += i;
    }
    return "Sum is " + sum;
});

app.Run();
