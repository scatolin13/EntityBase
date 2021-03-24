using System;

namespace FluntValidation.Validations
{
    public partial class EntityBase
    {
        public EntityBase IsGreaterThan(TimeSpan val, TimeSpan comparer, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(TimeSpan val, TimeSpan comparer, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(TimeSpan val, TimeSpan comparer, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(TimeSpan val, TimeSpan comparer, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsBetween(TimeSpan val, TimeSpan from, TimeSpan to, string property, string message)
        {
            if (!(val >= from && val <= to))
            {
                AddNotification(property, message);
            }

            return this;
        }
    }
}
