using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    
    public class Room
    {
      public   int Id { get; set; }

      
        public string Status { get; set; }

        [Required(ErrorMessage ="Nomrəni daxil edin")]
        public int RoomNo { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal DailyPrice { get; set; }



        [Required(ErrorMessage = "Müştərinin sayını daxil edin")]
        public int PersonCapacity { get; set; }

        

        [Required(ErrorMessage ="Uşaq sayını daxil edin")]
        public int ChildCapacity { get; set; }

        


        public int BedTypeId { get; set; }


        public BedType BedType { get; set; }


        public string Photo { get; set; }

        [NotMapped]
        public HttpPostedFileBase File { get; set; }

        [Required(ErrorMessage = "İzah Yazın"), MaxLength(50)]
        public string Desc { get; set; }

        public List<BookingDetails> BookingDetails { get; set; }

        public bool? IsDelete { get; set; }

        public List<Menu> Menu { get; set; }

        
    }
}