﻿using MyVet.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Data.Entities
{
    public class Owner : IEntity
    {
        public int Id { get; set; }

        public User User { get; set; }

        public ICollection<Pet> Pets { get; set; }

        public ICollection<Agenda> Agendas { get; set; }
    }
}
