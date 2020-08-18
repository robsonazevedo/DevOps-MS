using System;

namespace Domain.Entities
{
    public abstract class EntityBase : IComparable
    {
        public DateTime DateInsert { get; set; }

        public DateTime? DateUpdate { get; set; }
        public int Id { get; set; }

        public bool IsTest { get; set; } = false;

        public virtual int CompareTo(object obj)
        {
            var count = default(int);
            var properties = GetType().GetProperties();

            foreach (var p in properties)
            {
                if (p.Name.Equals("id", StringComparison.CurrentCultureIgnoreCase)) continue;

                if (p.GetValue(this) != obj.GetType().GetProperty(p.Name).GetValue(obj))
                {
                    count++;
                }
            }

            return count;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is EntityBase other))
            {
                return false;
            }

            return CompareTo(other) == 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
