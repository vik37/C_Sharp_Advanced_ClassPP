using SEDC.Adv.TryBeingFit.Domain.Entities;
using SEDC.Adv.TryBeingFit.Domain.Enums;
using SEDC.Adv.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services.Services
{
    public interface IUIService
    {
		void Welcome(User user);
		int ChooseEntiiesMenu<T>(List<T> entities) where T : IBaseEntity;
		int MainMenu(UserRole role);
		int AccountMenu();
		int ChooseMenu<T>(List<T> items);
		int LogInMenu();
		int RoleMenu();
		int TrainMany();
		int TrainManyItems<T>(List<T> item) where T : Training;
		void UpgradeToPremium();
	}
}
