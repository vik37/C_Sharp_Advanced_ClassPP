using SEDC.Adv.TryBeingFit.Domain.Interfaces;

namespace SEDC.Adv.TryBeingFit.Domain.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }

        public abstract string PrintInfo();
    }
}
