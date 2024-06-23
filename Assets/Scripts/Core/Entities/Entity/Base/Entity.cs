using System;

namespace Core.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        public Entity(Guid id)
        {
            Id = id;
        }
    }
}