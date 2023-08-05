using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunYonetimCore6584.Core.Entities
{
    public class Contact:IEntity
    {
        public int Id { get; set; }

        [DisplayName("Müşteri Adı"), Required(ErrorMessage = "{0} Boş Geçilemez!")]
        public string Name { get; set; }

        [DisplayName("Müşteri Soyadı")]
        public string? Surname { get; set; }

        [DisplayName("Telefon")]
        public string? Telephone { get; set; }

        [DisplayName("Email"), Required(ErrorMessage ="{0} Boş Geçilemez!")]
        public string Email { get; set; }

        [StringLength(1500), DisplayName("Mesaj"), Required]
        public string Message { get; set; }

        [DisplayName("Oluşturma Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
