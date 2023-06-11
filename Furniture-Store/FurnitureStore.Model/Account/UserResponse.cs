﻿using System;
using FurnitureStore.Model.Token;
using System.Reflection;

namespace FurnitureStore.Model.Account
{
    public class UserResponse
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string ProfileImage { get; set; }
        public string Comment { get; set; }
        public List<string> Roles { get; set; }
        public string FullName { get { return $"{FirstName ?? ""} {LastName ?? ""}"; } }
        public bool IsUser { get; set; }
        public TokenInfo Token { get; internal set; }
        public bool EmailConfirmed { get; set; }
    }
}

