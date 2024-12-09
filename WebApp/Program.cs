using Domain.Models;
using Infrastructure;
using Infrastructure.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var branch = new Branch();
// getall students
app.MapGet("/get-all-students", () =>
    {
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1,  FirstName = "John Doe", Age = 20 },
            new Student { Id = 2, FirstName = "Jane Doe", Age = 22 },
            new Student { Id = 3, FirstName = "Bob Smith", Age = 21 }
        };

        return students;
    })
    .WithName("GetStudentApi")
    .WithOpenApi();

app.MapGet("/get-student-by-id", (int id) =>
    {
        return studentService.GetStudentById(id);
    })
    .WithName("GetStudentByIdApi")
    .WithOpenApi();

//add
app.MapPost("/add-student", (Student student) =>
    {
        var result = studentService.AddStudent(student);
        return result;        
    
    })
    .WithName("AddStudent")
    .WithOpenApi();

//update
app.MapPut("/update-student", (Student student) =>
    {
        var result = studentService.UpdateStudent(student);
        return result;        
    
    })
    .WithName("UpdateStudent")
    .WithOpenApi();


//delete
app.MapDelete("/delete-student", (int id) =>
    {
        var result = studentService.DeleteStudent(id);
        return result;        
    
    })
    .WithName("DeleteStudent")
    .WithOpenApi();


app.Run();