using Common;
using NewCache;

namespace UITemplate
{
    public class Class1
    {
        public static string GetCombinedMessage()
        => $"{CommonHelper.GetMessage()} + {CacheHelper.GetMessage()}";
    }
}
