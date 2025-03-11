using System;

namespace Lab1.domain
{
    [Serializable]
    public class Entity<ID>
    {
        public ID Id { get; set; }

        public Entity(ID id)
        {
            Id = id;
        }
    }
}