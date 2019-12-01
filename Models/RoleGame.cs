using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoleHSETemp1.Models
{
    public class BoulingGame
    { 
        public int Id { get; set; }
        public string FIO { get; set; }
        public int countOfPlayers { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public DateTime dateOfGame { get; set; }


        public bool isActive { get; set; }

        public BoulingGame(string _FIO, DateTime _dateofgame, int _countofplayers, string _Phone, string _Mail, bool _isActive)
        {
            FIO = _FIO; dateOfGame = _dateofgame; Phone = _Phone; Mail = _Mail; countOfPlayers = _countofplayers; isActive = _isActive;
        }
    }
}