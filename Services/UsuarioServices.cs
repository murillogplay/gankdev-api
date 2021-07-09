
using System.Collections.Generic;
using GankdevApi.Models;
using GankdevApi.Interfaces;
using MongoDB.Driver;

namespace GankdevApi.Services{
    
    public class UsuarioServices : IUsuarioServices{

        private readonly IMongoCollection<Usuario> _usuario;
        public UsuarioServices(IDbClient dbClient){
            _usuario = dbClient.GetUsuarioCollection();
        }

        public List<Usuario> GetUsuarios() => _usuario.Find(usuario => true).ToList();
        
    }
}