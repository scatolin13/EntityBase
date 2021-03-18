namespace EntityBase.Validations
{
    public partial class EntityBase
    {
        public EntityBase IsFalse(bool val, string property, string message)
        {
            if (val)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsTrue(bool val, string property, string message) =>
            IsFalse(!val, property, message);
    }
}
