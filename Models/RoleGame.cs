using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoleHSETemp1.Models
{
    public class RoleGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime dateOfGame { get; set; }
        public int countOfPlayers { get; set; }
        public int authorID { get; set; }// id автора
        public string Description { get; set; } //то что видят на сайте все
        public string Notes { get; set; }//какие то внутренние заметки

        public bool isActive { get; set; }
        
        public RoleGame(string _name, DateTime _dateofgame, int _countofplayers, int _authorID, string _description, string _notes, bool _isActive)
        {
            Name = _name; dateOfGame = _dateofgame; Description = _description;Notes = _notes; countOfPlayers = _countofplayers; authorID = _authorID; isActive = _isActive;
        }
    }
}