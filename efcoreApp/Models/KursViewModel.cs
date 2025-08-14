using efcoreApp.Data;
using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Models
{
    public class KursViewModel
    {
        public int KursId { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Kurs Başlığı")]
        public string? Baslik { get; set; }
        public int OgretmenId { get; set; }
        public ICollection<KursKayit> kursKayitlari { get; set; } = new List<KursKayit>();
    }
}
