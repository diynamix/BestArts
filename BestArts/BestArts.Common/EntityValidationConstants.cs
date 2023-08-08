namespace BestArts.Common
{
    public static class EntityValidationConstants
    {
        public static class Product
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;

            public const int ImageUrlMinLength = 2;
            public const int ImageUrlMaxLength = 2048;

            public const string WidthMinValue = "0";
            public const string WidthMaxValue = "3000";

            public const string HeightMinValue = "0";
            public const string HeightMaxValue = "3000";

            public const string LengthMinValue = "0";
            public const string LengthMaxValue = "3000";

            public const string PriceMinValue = "0";
            public const string PriceMaxValue = "2000";

            public const string DiscountedPriceMinValue = "0";
            public const string DiscountedPriceMaxValue = "2000";
        }

        public static class Category
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;
        }

        public static class Cart
        {
            public const string QuantityMinValue = "1";
            public const string QuantityMaxValue = "10";
        }

        public static class OrderItem
        {
            public const string QuantityMinValue = "1";
            public const string QuantityMaxValue = "20";

            public const string PriceMinValue = "0";
            public const string PriceMaxValue = "2000";
        }

        public static class Order
        {
            public const int AddressMinLength = 10;
            public const int AddressMaxLength = 500;

            public const int OrderStatusMinValue = 0;
            public const int OrderStatusMaxValue = 3;
        }

        public static class User
        {
            public const int UserNameMaxLength = 30;
            public const int UserNameMinLength = 3;

            public const int PasswordMinLength = 6;
            public const int PasswordMaxLength = 100;

            public const int FirstNameMinLength = 1;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 1;
            public const int LastNameMaxLength = 50;

            public const int PhoneNumberMinLength = 7;
            public const int PhoneNumberMaxLength = 15;
        }
    }
}
