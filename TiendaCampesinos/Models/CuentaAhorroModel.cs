using System.ComponentModel.DataAnnotations;

namespace TiendaCampesinos.Models
{

    public class CuentaAhorroModel{

        [Key]
        public long Id { get; set; }
        public string IdentificacionAsociada { get; set; }
        public string NumeroCuenta { get; set; }

    }
    

}