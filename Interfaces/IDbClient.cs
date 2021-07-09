using GankdevApi.Models;
using MongoDB.Driver;

namespace GankdevApi.Interfaces{
    public interface IDbClient{
        IMongoCollection<Usuario> GetUsuarioCollection();
    }
}