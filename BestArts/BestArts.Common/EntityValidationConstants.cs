namespace BestArts.Common
{
    public static class EntityValidationConstants
    {
        public static class Category
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;
        }

        public static class Product
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;

            public const int ImageUrlMaxLength = 2048;

            public const string PriceMinValue = "0";
            public const string PriceMaxValue = "1000";
        }

        public static class Size
        {
            public const string WidthMinValue = "1";
            public const string WidthMaxValue = "1000";

            public const string HeightMinValue = "1";
            public const string HeightMaxValue = "1000";

            public const string LengthMinValue = "1";
            public const string LengthMaxValue = "1000";
        }
    }
}
