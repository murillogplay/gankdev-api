using GankdevApi.Interfaces;
using GankdevApi.Models;
using GankdevApi.Utils;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GankdevApi.Services{
    public class DbClient : IDbClient{
        private readonly IMongoCollection<Usuario> _usuarios;
        public DbClient(IOptions<GankdevDbConfig> gankdevDbConfig){
            var client = new MongoClient(gankdevDbConfig.Value.Connection_String);
            var database = client.GetDatabase(gankdevDbConfig.Value.DataBase_Name);
            _usuarios = database.GetCollection<Usuario>(gankdevDbConfig.Value.Collection_Name);

        }
        public IMongoCollection<Usuario> GetUsuarioCollection() => _usuarios;
    }
}