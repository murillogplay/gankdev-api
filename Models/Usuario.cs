using MongoDB.Bson.Serialization.Attributes;

namespace GankdevApi.Models{
    public class Usuario{
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id{get; set;}
        public string Nome{get; set;}
        public string Email{get; set;}
        public string Senha{get; set;}
    } 
}