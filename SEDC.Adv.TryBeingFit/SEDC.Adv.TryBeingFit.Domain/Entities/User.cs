using SEDC.Adv.TryBeingFit.Domain.Enums;
using SEDC.Adv.TryBeingFit.Domain.Interfaces;

namespace SEDC.Adv.TryBeingFit.Domain.Entities
{
	public abstract class User : BaseEntity, IUser
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public UserRole Role { get; set; }
	}
}
