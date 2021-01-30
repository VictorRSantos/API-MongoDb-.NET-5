using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Api.Data.Collections
{
    /* Essa classe é a representação da nossa collection(Tabelas) no banco*/
    public class Infectado
    {

        public Infectado(DateTime dataNascimento, string sexo, double latitude, double longitude)
        {

            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);

        }

    
        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        // Biblioteca do MongoDB 
        /*Instação via terminal: dotnet add package MongoDB.Driver*/
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }


    }
}