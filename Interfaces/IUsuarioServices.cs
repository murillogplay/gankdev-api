using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GankdevApi.Models;

namespace GankdevApi.Interfaces{
    public interface IUsuarioServices{
        List<Usuario> GetUsuarios(); 
        Usuario GetUsuario(string id); 
        Usuario AddUsuario(Usuario usuario);
        void DeleteUsuario(string id);
        Usuario UpdateUsuario(Usuario usuario);
        Usuario Authenticate(Usuario usuario);

    }

}
