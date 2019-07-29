using Newtonsoft.Json;

namespace HelloSchool.Models
{
    
    public class  Usuario
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("Usuario")]
        public string usuario { get; set; }

        [JsonProperty("Contraseña")]
        public string Contraseña { get; set; }

        [JsonProperty("Correo")]
        public string Correo { get; set; }

        [JsonProperty("TipoUsuario")]
        public string TipoUsuario { get; set; }

    }
}