using SEDC.TryBeingFit_.Domain.Entities;
using SEDC.TryBeingFit_.Domain.Interfaces;
using SEDC.TryBeingFit_.Domain.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SEDC.TryBeingFit_.Services.Services
{
    public interface IUIService
    {
        void Welcome(User user);
        int ChoiseEntitiesMany<T>(List<T> entities) where T : IBaseEntity;
        int MainMany(UserRoll roll);
        int ChooseMany<T>(List<T> items);
        int LogInMany();
        int RoleMany();
    }
}
