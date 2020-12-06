using System.ComponentModel.DataAnnotations;

namespace TiendaCampesinos.Models
{

    public class Usuario{

        [Key]
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long IdInfoBasica { get; set; }
        public long IdInfoPago { get; set; }
        public long IdInfoDomicilio { get; set; }

    }
    

}