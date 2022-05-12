using System;

namespace CapeApi.Shared
{
    public static class ExtensionMenthods
    {
        public static string ToFormattedDateString(this DateTime? src)
        {
            if (src == null || !src.HasValue)
                return string.Empty;

            return src.Value.ToString("dd'-'MMM'-'yyyy");
        }
    }
}
