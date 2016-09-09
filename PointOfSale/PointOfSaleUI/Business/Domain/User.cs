using PointOfSaleUI.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Domain
{
    /// <summary>
    ///     Represents a system user
    /// </summary>
    [Serializable]
    public class User : ISerializable
    {

        public const string ANONYMOUS_USER_NAME = "Anónimo";

        private string username;
        public string Username
        {
            get { return username; }
        }

        private string passwordHash;
        public string PasswordHash
        {
            get { return passwordHash; }
            set { passwordHash = value; }
        }

        private UserRole role;
        public UserRole Role
        {
            get { return role; }
            set { role = value; }
        }

        public User(string username,string passwordHash,UserRole role)
        {
            if(role == UserRole.ANONYMOUS && !(username.Equals(ANONYMOUS_USER_NAME)))
            {
                throw new InvalidUsersUsernameException();
            }
            this.username = username;
            PasswordHash = passwordHash;
            Role = role;
        }

        public User(SerializationInfo info, StreamingContext context)
        {
            username = info.GetString("username");
            PasswordHash = info.GetString("passwordHash");
            if (info.GetString("role").Equals(UserRole.ADMIN.ToString()))
            {
                Role = UserRole.ADMIN;
            }
            else if (info.GetString("role").Equals(UserRole.ANONYMOUS.ToString()))
            {
                Role = UserRole.ANONYMOUS;
            }
        }

        public bool IsAnonymous
        {
            get { return role == UserRole.ANONYMOUS; }
        }

        public bool IsAdmin
        {
            get { return role == UserRole.ADMIN; }
        }

        /* ====================== Serializable methods =========================== */

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("username", Username);
            info.AddValue("passwordHash", PasswordHash);
            info.AddValue("role", Role.ToString());
        }
    }
}
