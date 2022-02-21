using System;

namespace COM3D2.PropMyItem.Plugin
{
    // Token: 0x0200000C RID: 12
    public class SMenuInfo
    {
        // Token: 0x06000051 RID: 81 RVA: 0x00008214 File Offset: 0x00006414
        public SMenuInfo()
        {
        }

        // Token: 0x06000052 RID: 82 RVA: 0x00008264 File Offset: 0x00006464
        public SMenuInfo(MenuInfo menuInfo)
        {
            this.ItemName = menuInfo.ItemName;
            this.FileName = menuInfo.FileName;
            this.IconName = menuInfo.IconName;
            this.Priority = menuInfo.Priority;
            this.ColorSetMPN = menuInfo.ColorSetMPN;
            this.ColorSetMenuName = menuInfo.ColorSetMenuName;
            this.MPN = menuInfo.MPN;
        }

        // Token: 0x0400005A RID: 90
        public string ItemName = string.Empty;

        // Token: 0x0400005B RID: 91
        public string FileName = string.Empty;

        // Token: 0x0400005C RID: 92
        public string IconName = string.Empty;

        // Token: 0x0400005D RID: 93
        public float Priority;

        // Token: 0x0400005E RID: 94
        public MPN ColorSetMPN = MPN.head;

        // Token: 0x0400005F RID: 95
        public string ColorSetMenuName = string.Empty;

        // Token: 0x04000060 RID: 96
        public MPN MPN = MPN.head;
    }
}
