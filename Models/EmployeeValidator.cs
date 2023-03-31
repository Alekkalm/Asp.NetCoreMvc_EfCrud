using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication11CRUD.Models
{
    //валидация полей на стороне сервера
    public class EmployeeValidator
    {
        [Required] //обязательное поле
        [MaxLength(50)] //максимальное количество символов
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Employee Salary")]
        public decimal Salary { get; set; }

        [Required]
        [Display(Name = "Joining Date")]
        public decimal JoiningDate { get; set; }
    }

    [ModelMetadataType(typeof(EmployeeValidator))]//применяем валидацию к классу Employee
    public partial class Employee
    {
    }
}
