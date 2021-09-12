using PIZZAAPI;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
PizzaConfig config = new();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", () => "Hello World!");

app.MapGet("/menu", () => {
    return config.GetMenu();
});

app.MapGet("/toppings", () => {
    return config.GetToppings();
});

app.Run();
