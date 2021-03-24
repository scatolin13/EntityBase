using System;

namespace FluntValidation.Validations
{
    public partial class EntityBase
    {
        public EntityBase AreEquals(Guid val, Guid comparer, string property, string message)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (val.ToString() != comparer.ToString())
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(Guid val, Guid comparer, string property, string message)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (val.ToString() == comparer.ToString())
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsEmpty(Guid val, string property, string message)
        {
            if (val != Guid.Empty)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsNotEmpty(Guid val, string property, string message)
        {
            if (val == Guid.Empty)
            {
                AddNotification(property, message);
            }

            return this;
        }
    }
}
