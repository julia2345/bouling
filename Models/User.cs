using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoleHSETemp1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string nickName { get; set; } // Фамилия имя
        public int accessLevel { get; set; } // уровень доступа
        public string position { get; set; } //о себе
        public string notes { get; set; }//какие то внутренние заметки

        public string vk { get; set; }

        public string email { get; set; }

        public bool isActive { get; set; }

        public bool IsDeleted { get; set; }

        public User()
        {

        }
        public User(string _name, int _accessLevel, string _position, string _notes, string _vk, string _email, bool _isActive)
        {
            nickName = _name; accessLevel=_accessLevel; position = _position; notes = _notes; isActive = _isActive; vk = _vk; email = _email; IsDeleted = false;
        }
    }
}