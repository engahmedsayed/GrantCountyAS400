namespace GrantCountyAs400.PersistenceAdapter.Extensions
{
    public static class StringExtentions
    {
        public static string SplitName(this string name, char splitter, NameEnum nameSplit)
        {
            if (nameSplit == NameEnum.FirstName)
                return name.Split(splitter)[1];
            return name.Split(splitter)[0];
        }

        public static string TrimAndLower(this string value)
        {
            return value?.Trim().ToLower();
        }
    }

    public enum NameEnum
    {
        FirstName = 1,
        LastName = 2
    }
}