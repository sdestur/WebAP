﻿using Bogus;
using System.Collections.Generic;
using System.ComponentModel;
using WebAPI1.Models;

namespace WebAPI1.Ex1
{
    public class Fake
    {
        private static List<User> _users;

        public static List<User> GetUsers(int number)
        {
            if (_users==null)
            {
                _users = new Faker<User>().RuleFor(u => u.Id, f => f.IndexFaker + 1)
                                      .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                                      .RuleFor(u => u.LastName, f => f.Name.LastName())
                                      .RuleFor(u => u.Adress, f => f.Address.FullAddress())
                                      .Generate(number);
            }
            
            return _users;
        }
    }
}
