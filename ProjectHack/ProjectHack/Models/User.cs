﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectHack.Models
{
	public class User
	{
		public User()
		{
			
		}
		public User(string username, string password, string email)
		{
			this.Username = username;
			this.Password = password;
			this.Email = email;
		}
		public int UserId { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string Categories { get; set; }
<<<<<<< HEAD
		public string Activities { get; set; }
=======
>>>>>>> 6f69e16ce64f9c2123f548d01c01f33beb50c8e6

	}
}