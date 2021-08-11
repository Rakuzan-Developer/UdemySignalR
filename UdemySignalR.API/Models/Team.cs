﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemySignalR.API.Models
{
    public class Team
    {
        //team.users.add --> takım üstünden user oluşturulacaksa userlar listelenip sonrasında takıma eklenecek.
        public Team()
        {
            Users = new List<User>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
