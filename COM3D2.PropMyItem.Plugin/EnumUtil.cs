using System;

namespace COM3D2.PropMyItem.Plugin
{
    // Token: 0x02000005 RID: 5
    public static class EnumUtil
    {
        // Token: 0x06000013 RID: 19 RVA: 0x00002716 File Offset: 0x00000916
        public static T Parse<T>(string value)
        {
            return EnumUtil.Parse<T>(value, true);
        }

        // Token: 0x06000014 RID: 20 RVA: 0x0000271F File Offset: 0x0000091F
        public static T Parse<T>(string value, bool ignoreCase)
        {
            return (T)((object)Enum.Parse(typeof(T), value, ignoreCase));
        }

        // Token: 0x06000015 RID: 21 RVA: 0x00002737 File Offset: 0x00000937
        public static bool TryParse<T>(string value, out T result)
        {
            return EnumUtil.TryParse<T>(value, true, out result);
        }

        // Token: 0x06000016 RID: 22 RVA: 0x00002744 File Offset: 0x00000944
        public static bool TryParse<T>(string value, bool ignoreCase, out T result)
        {
            bool result2;
            try
            {
                result = (T)((object)Enum.Parse(typeof(T), value, ignoreCase));
                result2 = true;
            }
            catch
            {
                result = default(T);
                result2 = false;
            }
            return result2;
        }
    }
}
