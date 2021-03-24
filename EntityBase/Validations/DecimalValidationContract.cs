namespace FluntValidation.Validations
{
    public partial class EntityBase
    {
        #region IsGreaterThan

        public EntityBase IsGreaterThan(decimal val, decimal comparer, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(double val, decimal comparer, string property, string message)
        {
            if (val <= (double)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(float val, decimal comparer, string property, string message)
        {
            if (val <= (float)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(long val, decimal comparer, string property, string message)
        {
            if (val <= (float)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(int val, decimal comparer, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        #endregion IsGreaterThan

        #region IsGreaterOrEqualsThan

        public EntityBase IsGreaterOrEqualsThan(decimal val, decimal comparer, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(double val, decimal comparer, string property, string message)
        {
            if (val < (double)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(float val, decimal comparer, string property, string message)
        {
            if (val < (float)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(long val, decimal comparer, string property, string message)
        {
            if (val < (float)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(int val, decimal comparer, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        #endregion IsGreaterOrEqualsThan

        #region IsLowerThan

        public EntityBase IsLowerThan(decimal val, decimal comparer, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(double val, decimal comparer, string property, string message)
        {
            if (val >= (double)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(float val, decimal comparer, string property, string message)
        {
            if (val >= (float)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(long val, decimal comparer, string property, string message)
        {
            if (val >= (float)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(int val, decimal comparer, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        #endregion IsLowerThan

        #region IsLowerOrEqualsThan

        public EntityBase IsLowerOrEqualsThan(decimal val, decimal comparer, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(double val, decimal comparer, string property, string message)
        {
            if (val > (double)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(float val, decimal comparer, string property, string message)
        {
            if (val > (float)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(long val, decimal comparer, string property, string message)
        {
            if (val > (float)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(int val, decimal comparer, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        #endregion IsLowerOrEqualsThan

        #region AreEquals

        public EntityBase AreEquals(decimal val, decimal comparer, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase AreEquals(double val, decimal comparer, string property, string message)
        {
            if (val != (double)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase AreEquals(float val, decimal comparer, string property, string message)
        {
            if (val != (float)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase AreEquals(long val, decimal comparer, string property, string message)
        {
            if (val != (float)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase AreEquals(int val, decimal comparer, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        #endregion AreEquals

        #region AreNotEquals

        public EntityBase AreNotEquals(decimal val, decimal comparer, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(double val, decimal comparer, string property, string message)
        {
            if (val == (double)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(float val, decimal comparer, string property, string message)
        {
            if (val == (float)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(long val, decimal comparer, string property, string message)
        {
            if (val == (float)comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(int val, decimal comparer, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(property, message);
            }

            return this;
        }

        #endregion AreNotEquals

        #region Between

        public EntityBase IsBetween(decimal val, decimal from, decimal to, string property, string message)
        {
            if (!(val >= from && val <= to))
            {
                AddNotification(property, message);
            }

            return this;
        }

        #endregion Between

        public EntityBase IsNullOrNullable(decimal? val, string property, string message)
        {
            if (val == null || !val.HasValue)
            {
                AddNotification(property, message);
            }

            return this;
        }
    }
}
