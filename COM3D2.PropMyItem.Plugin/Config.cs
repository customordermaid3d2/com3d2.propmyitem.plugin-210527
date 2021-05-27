using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace COM3D2.PropMyItem.Plugin
{
    // Token: 0x02000004 RID: 4
    public class Config
    {
        // Token: 0x17000001 RID: 1
        // (get) Token: 0x06000009 RID: 9 RVA: 0x0000249B File Offset: 0x0000069B
        // (set) Token: 0x0600000A RID: 10 RVA: 0x000024A3 File Offset: 0x000006A3
        public List<string> TargetBGList
        {
            get
            {
                return this._targetBGList;
            }
            set
            {
                this._targetBGList = value;
            }
        }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x0600000B RID: 11 RVA: 0x000024AC File Offset: 0x000006AC
        // (set) Token: 0x0600000C RID: 12 RVA: 0x000024B4 File Offset: 0x000006B4
        public List<SMenuInfo> MenuItems
        {
            get
            {
                return this._menuItems;
            }
            set
            {
                this._menuItems = value;
            }
        }

        // Token: 0x17000003 RID: 3
        // (get) Token: 0x0600000D RID: 13 RVA: 0x000024C0 File Offset: 0x000006C0
        public static Config Instance
        {
            get
            {
                if (Config._config == null)
                {
                    string text = Directory.GetCurrentDirectory() + "\\Sybaris\\UnityInjector\\Config\\PropMyItem.xml";
                    Config._config = new Config();
                    Config._config.SetDefault();
                    if (File.Exists(text))
                    {
                        Config._config.Load(text);
                    }
                    else
                    {
                        Config._config.Save();
                    }
                }
                return Config._config;
            }
        }

        // Token: 0x0600000E RID: 14 RVA: 0x0000251C File Offset: 0x0000071C
        public void Load(string filePath)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
                using (StreamReader streamReader = new StreamReader(filePath, new UTF8Encoding(false)))
                {
                    Config config = (Config)xmlSerializer.Deserialize(streamReader);
                    this.TargetBGList.Clear();
                    this.TargetBGList.AddRange(config.TargetBGList.ToArray());
                    this.MenuItems = config.MenuItems;
                }
            }
            catch (Exception)
            {
                this.SetDefault();
            }
        }

        // Token: 0x0600000F RID: 15 RVA: 0x000025B4 File Offset: 0x000007B4
        public void SetDefault()
        {
            try
            {
                string[] collection = new string[]
                {
                    "MyRoom",
                    "MyRoom_Night",
                    "Shukuhakubeya_BedRoom",
                    "Shukuhakubeya_BedRoom_Night",
                    "Soap",
                    "SMClub",
                    "HeroineRoom_A1",
                    "HeroineRoom_A1_night",
                    "HeroineRoom_B1",
                    "HeroineRoom_B1_night",
                    "HeroineRoom_C1",
                    "HeroineRoom_C1_night",
                    "HeroineRoom_A",
                    "HeroineRoom_A_night",
                    "HeroineRoom_B",
                    "HeroineRoom_B_night",
                    "HeroineRoom_C",
                    "HeroineRoom_C_night"
                };
                this.TargetBGList.AddRange(collection);
            }
            catch (Exception)
            {
            }
        }

        // Token: 0x06000010 RID: 16 RVA: 0x00002684 File Offset: 0x00000884
        public void Save()
        {
            string filePath = Directory.GetCurrentDirectory() + "\\Sybaris\\UnityInjector\\Config\\PropMyItem.xml";
            this.Save(filePath);
        }

        // Token: 0x06000011 RID: 17 RVA: 0x000026A8 File Offset: 0x000008A8
        public void Save(string filePath)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
                StreamWriter streamWriter = new StreamWriter(filePath, false, new UTF8Encoding(false));
                xmlSerializer.Serialize(streamWriter, this);
                streamWriter.Close();
            }
            catch (Exception value)
            {
                Console.WriteLine(value);
            }
        }

        // Token: 0x04000004 RID: 4
        private List<string> _targetBGList = new List<string>();

        // Token: 0x04000005 RID: 5
        private List<SMenuInfo> _menuItems = new List<SMenuInfo>();

        // Token: 0x04000006 RID: 6
        private static Config _config;
    }
}
