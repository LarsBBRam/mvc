﻿using Core.Classes.Controllers;
using Core.Classes.Models;
using Core.Classes.Views;
namespace App;

class Program
{
    static void Main(string[] args)
    {
        var app = new TaskController(new TaskContext(), new ViewGenerator());
        app.Run();
    }
}
