using System;

namespace GrantCountyAs400.Web.Extensions
{
    public static class DecimalExtensions
    {
        public static string MaskSSN(this decimal ssnNumber)
        {
            var ssnString = ssnNumber.ToString();
            return String.Format("***-**-{0}", ssnString.Substring(ssnString.Length - 4, 4));
        }
    }
}