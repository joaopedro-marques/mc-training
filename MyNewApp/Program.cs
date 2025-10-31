using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseRewriter(new RewriteOptions().AddRedirect("taks/(.*)", "todos/$1"));
app.Use(async (context, next) =>
{
  Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}{DateTime.Now}");
  await next(context);
  Console.WriteLine($"Response: {context.Response.StatusCode}{DateTime.Now}");
});
var todos = new List<TodoItem>();
app.MapGet("/todos", () => todos);
app.MapGet("/todos/{id}", Results<Ok<TodoItem>, NotFound> (int id) => 
{
  var todo = todos.FirstOrDefault(t => t.Id == id);
  return todo is null ? TypedResults.NotFound() : TypedResults.Ok(todo);
});

app.MapPost("/todos", (TodoItem todo) => 
{ 
  todos.Add(todo);
  return TypedResults.Created("/todo/{id}", todo);
})
.AddEndpointFilter(async (context, next) =>
{
  var taskArgumente = context.GetArgument<TodoItem>(0);
  var errors = new Dictionary<string, string[]>();
  if (taskArgumente.DueDate < DateTime.Now)
    errors["DueDate"] = new[] { "DueDate must be in the future" };  
  if (taskArgumente.isCompleted)
  {
    errors.Add(nameof(TodoItem.isCompleted), ["Cannot add completed tasks"]);
  }
  if (errors.Count > 0)
    return TypedResults.BadRequest(errors);
  return await next(context);
});

app.MapDelete("/todos/{id}", (int id) => 
{ 
  todos.RemoveAll(t => id == t.Id);
  return TypedResults.NoContent();
});

app.Run();

public record TodoItem(int Id, string Name, DateTime DueDate, bool isCompleted);