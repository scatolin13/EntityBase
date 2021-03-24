namespace FluntValidation.Validations
{
    public partial class EntityBase
    {
        public EntityBase IsNull(object obj, string property, string message)
        {
            if (obj != null)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsNotNull(object obj, string property, string message)
        {
            if (obj == null)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase AreEquals(object obj, object comparer, string property, string message)
        {
            if (!obj.Equals(comparer))
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(object obj, object comparer, string property, string message)
        {
            if (obj.Equals(comparer))
            {
                AddNotification(property, message);
            }

            return this;
        }
    }
}
