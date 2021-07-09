using System;
using System.Collections.Generic;
using GankdevApi.Models;

namespace GankdevApi.Interfaces{
    public interface IUsuarioServices{
        List<Usuario> GetUsuarios(); 
    }

}
