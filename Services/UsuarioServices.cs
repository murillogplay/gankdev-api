
using System.Collections.Generic;
using GankdevApi.Models;
using GankdevApi.Interfaces;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace GankdevApi.Services{
    
    public class UsuarioServices : IUsuarioServices{

        private readonly IMongoCollection<Usuario> _usuario;
        public UsuarioServices(IDbClient dbClient){
            _usuario = dbClient.GetUsuarioCollection();
        }

        public Usuario AddUsuario(Usuario usuario)
        {
            _usuario.InsertOne(usuario);
            return usuario;
        }

        public void DeleteUsuario(string id)
        {
            _usuario.DeleteOne(usuario => usuario.Id == id);
        }

        public Usuario GetUsuario(string id) => _usuario.Find(usuario => usuario.Id == id).First();

        public List<Usuario> GetUsuarios() => _usuario.Find(usuario => true).ToList();

        public Usuario UpdateUsuario(Usuario usuario)
        {
            GetUsuario(usuario.Id);
            _usuario.ReplaceOne( u => u.Id == usuario.Id, usuario);
            return usuario;
        }

        public Usuario Authenticate(Usuario usuario) => _usuario.Find(us => us.Email == usuario.Email && us.Senha == usuario.Senha).First();
           
       
    }
}