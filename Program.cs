var builder = WebApplication.CreateBuilder(args); // создаем строитель приложени€ ASP.NET Core

var app = builder.Build(); // builder.Build() конфигурирует все сервисы и создает объект WebApplication

// √лавна€ страница
app.Map("/", () => // метод Map() регистрирует обработчик дл€ указанного пути
{
    var html = """
    <!DOCTYPE html>
    <html>
    <head>
        <title>Main</title>
    </head>
    <body>
        <h1>Main</h1>
        <a href="/page1">Page 1</a><br>
        <a href="/page2">Page 2</a><br>
    </body>
    </html>
    """;
    return Results.Content(html, "text/html");
});

// —траница 1
app.Map("/page1", () => // когда пользователь переходит по адресу /page1, выполнитс€ этот обработчик
{
    var html = """
    <!DOCTYPE html>
    <html>
    <head>
        <title>Page 1</title>
    </head>
    <body>
        <h1>Page 1</h1>
        <a href="/">Main</a><br>
        <a href="/page2">Page 2</a><br>
    </body>
    </html>
    """;
    return Results.Content(html, "text/html");
});

// —траница 2
app.Map("/page2", () => // когда пользователь переходит по адресу /page2, выполнитс€ этот обработчик
{
    var html = """
    <!DOCTYPE html>
    <html>
    <head>
        <title>Page 2</title>
    </head>
    <body>
        <h1>Page 2</h1>
        <a href="/">Main</a><br>
        <a href="/page1">Page 1</a><br>
    </body>
    </html>
    """;
    return Results.Content(html, "text/html");
});

// «апускаем веб-приложение
// app.Run() начинает прослушивать HTTP запросы на указанных в конфигурации адресах
app.Run();