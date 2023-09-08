#region Usings
using System.Collections.Generic;
#endregion

namespace dotnet_rpg.Models
{
    public class User
    {
        #region Properties User
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<Character> Characters { get; set; }
        #endregion
    }
}