﻿using Caelan.Frameworks.BIZ.NUnit.DTO;
using Caelan.Frameworks.BIZ.NUnit.Models;
using Caelan.Frameworks.Common.Classes;

namespace Caelan.Frameworks.BIZ.NUnit.Mappers
{
	public class UserMapper : DefaultMapper<UserDTO, User>
	{
		public override void Map(UserDTO source, User destination)
		{
			destination.Id = source.Id;
			destination.Login = source.Login;
			destination.Password = source.Password;
		}
	}
}