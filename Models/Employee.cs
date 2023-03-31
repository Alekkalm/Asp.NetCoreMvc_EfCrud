using System;
using System.Collections.Generic;

namespace WebApplication11CRUD.Models;

//модель объекта хранящегося в базе данных
public partial class Employee
{
    public int EmployeeId { get; set; } //идентификатор

    public string Name { get; set; } = null!; //имя

    public string? Address { get; set; } //адрес

    public string? Designation { get; set; } //должность

    public decimal Salary { get; set; } //зарплата

    public DateTime JoiningDate { get; set; } //дата вступления в должность
}
