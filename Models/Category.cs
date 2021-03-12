using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreShopRocky.Models
{
    public class Category
    {
        // Первичный ключ
        [Key]
        public int Id { get; set; }
        // Значит, что поле обязательно для заполнения
        [Required]
        public string Name { get; set; }
        // Отображение на вьюшке
        [DisplayName("Display Order")]
        // Значит, что поле обязательно для заполнения
        [Required]
        // Минимальное и максимальное значение, а так же сообщение об ошибке
        [Range(1, int.MaxValue, ErrorMessage ="Порядок отображения категорий должен быть больше 0")]
        public int DisplayOrder { get; set; }
    }
}
