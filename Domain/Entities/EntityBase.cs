using System;

namespace Domain.Entities
{
    public abstract class EntityBase : IComparable
    {
        public int Id { get; set; }

        public DateTime DateInsert { get; set; }

        public DateTime? DateUpdate { get; set; }

        public bool IsTest { get; set; } = false;

        public virtual int CompareTo(object other)
        {
            var count = default(int);
            var properties = GetType().GetProperties();

            foreach (var p in properties)
            {
                if (p.Name.Equals("id", StringComparison.CurrentCultureIgnoreCase)) continue;

                if (p.GetValue(this) != other.GetType().GetProperty(p.Name).GetValue(other))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
