using Microsoft.AspNetCore.Identity;

namespace APIDEVSteam.Models
{
    public class Usuario : IdentityUser
    {

        public class Usuarioas : IdentityUser
        {

            public Usuario() : base()
            {
            }

            public string? NomeCompleto { get; set; }
            public DateOnly DataNascimento { get; set; }
        }
    }
