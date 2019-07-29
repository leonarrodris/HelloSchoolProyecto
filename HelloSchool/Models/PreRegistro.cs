using Newtonsoft.Json;

namespace HelloSchool.Models
{
    
    public class  PreRegistro
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("TipoDocumento")]
        public string TipoDocumento { get; set; }

        [JsonProperty("NoDocumento")]
        public string NoDocumento { get; set; }

        [JsonProperty("Apellidos")]
        public string Apellidos { get; set; }

        [JsonProperty("Nombres")]
        public string Nombres { get; set; }

        [JsonProperty("Correo")]
        public string Correo { get; set; }

        [JsonProperty("Celular")]
        public string Celular { get; set; }

        [JsonProperty("Parentesco")]
        public string Parentesco { get; set; }

        [JsonProperty("TipoDocumentoEstudiante")]
        public string TipoDocumentoEstudiante { get; set; }

        [JsonProperty("NoDocumentoEstudiante")]
        public string NoDocumentoEstudiante { get; set; }

        [JsonProperty("ApellidosEstudiante")]
        public string ApellidosEstudiante { get; set; }

        [JsonProperty("NombresEstudiante")]
        public string NombresEstudiante { get; set; }

        [JsonProperty("Estado")]
        public bool Estado { get; set; }

    }
}