using System;
using System.Collections.Generic;
using UnityEngine;

namespace COM3D2.PropMyItem.Plugin
{
    // Token: 0x02000007 RID: 7
    public class MenuInfo
    {
        // Token: 0x06000025 RID: 37 RVA: 0x00002B10 File Offset: 0x00000D10
        public MenuInfo()
        {
        }

        // Token: 0x06000026 RID: 38 RVA: 0x00002B94 File Offset: 0x00000D94
        public MenuInfo(SMenuInfo menuInfo)
        {
            this.ItemName = menuInfo.ItemName;
            this.FileName = menuInfo.FileName;
            this.IconName = menuInfo.IconName;
            this.Priority = menuInfo.Priority;
            this.ColorSetMPN = menuInfo.ColorSetMPN;
            this.ColorSetMenuName = menuInfo.ColorSetMenuName;
            this.MPN = menuInfo.MPN;
        }

        // Token: 0x04000011 RID: 17
        public string ItemName = string.Empty;

        // Token: 0x04000012 RID: 18
        public string FileName = string.Empty;

        // Token: 0x04000013 RID: 19
        public string IconName = string.Empty;

        // Token: 0x04000014 RID: 20
        public float Priority;

        // Token: 0x04000015 RID: 21
        public Texture2D Icon;

        // Token: 0x04000016 RID: 22
        public MPN ColorSetMPN = MPN.head;

        // Token: 0x04000017 RID: 23
        public string ColorSetMenuName = string.Empty;

        // Token: 0x04000018 RID: 24
        public List<MenuInfo> VariationMenuList = new List<MenuInfo>();

        // Token: 0x04000019 RID: 25
        public List<MenuInfo> ColorSetMenuList = new List<MenuInfo>();

        // Token: 0x0400001A RID: 26
        public int ColorNumber;

        // Token: 0x0400001B RID: 27
        public MPN MPN = MPN.head;

        // Token: 0x0400001C RID: 28
        public bool IsMod;

        // Token: 0x0400001D RID: 29
        public bool IsOfficialMOD;

        // Token: 0x0400001E RID: 30
        public bool IsShopTarget;

        // Token: 0x0400001F RID: 31
        public bool IsHave = true;

        // Token: 0x04000020 RID: 32
        public string FilePath = string.Empty;

        // Token: 0x04000021 RID: 33
        public string CategoryName = string.Empty;

        // Token: 0x04000022 RID: 34
        public bool IsFavorite;

        // Token: 0x04000023 RID: 35
        public bool IsColorLock;

        // Token: 0x04000024 RID: 36
        public bool IsError;
    }
}
