using System;

namespace FluntValidation.Validations
{
    public partial class EntityBase
    {
        public EntityBase IsGreaterThan(DateTime val, DateTime comparer, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(DateTime val, DateTime comparer, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(DateTime val, DateTime comparer, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(DateTime val, DateTime comparer, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsBetween(DateTime val, DateTime from, DateTime to, string property, string message)
        {
            if (!(val >= from && val <= to))
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsNullOrNullable(DateTime? val, string property, string message)
        {
            if (val == null || !val.HasValue)
            {
                AddNotification(property, message);
            }

            return this;
        }
    }
}
