using System;
using System.Collections.Generic;
using System.Linq;

namespace COM3D2.PropMyItem.Plugin
{
	// Token: 0x02000002 RID: 2
	public class AutoShoesHide
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public AutoShoesHide()
		{
			this.checkMPNs = new MPN[]
			{
				MPN.acchat,
				MPN.headset,
				MPN.wear,
				MPN.skirt,
				MPN.onepiece,
				MPN.mizugi,
				MPN.bra,
				MPN.panz,
				MPN.stkg
			};
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020A8 File Offset: 0x000002A8
		public void Update()
		{
			try
			{
				if (UserConfig.Instance.IsAutoShoesHide)
				{
					List<Maid> visibleMaidList = CommonUtil.GetVisibleMaidList();
					if (visibleMaidList.Count != 0)
					{
						string bgname = GameMain.Instance.BgMgr.GetBGName();
						if (!(this._lastBGName == bgname) || this._lastMaidCount != visibleMaidList.Count)
						{
							if (Config.Instance.TargetBGList.Contains(bgname, StringComparer.OrdinalIgnoreCase))
							{
								using (List<Maid>.Enumerator enumerator = visibleMaidList.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										Maid maid = enumerator.Current;
										if (maid.IsAllProcPropBusy)
										{
											return;
										}
										if (maid.GetProp(MPN.shoes).strTempFileName != "_i_shoes_del.menu")
										{
											Menu.SetMaidItemTemp(maid, "_i_shoes_del.menu", true);
											maid.AllProcProp();
										}
									}
									goto IL_184;
								}
							}
							foreach (Maid maid2 in visibleMaidList)
							{
								if (maid2.IsAllProcPropBusy)
								{
									return;
								}
								bool flag = true;
								foreach (MPN mpn in this.checkMPNs)
								{
									MaidProp prop = maid2.GetProp(mpn);
									if (prop.strFileName == prop.strTempFileName)
									{
										flag = false;
										break;
									}
								}
								if (flag && maid2.GetProp(MPN.shoes).strTempFileName == "_i_shoes_del.menu")
								{
									maid2.ResetProp(MPN.shoes, false);
									maid2.AllProcProp();
								}
							}
							IL_184:
							this._lastBGName = bgname;
							this._lastMaidCount = visibleMaidList.Count;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000001 RID: 1
		private string _lastBGName = string.Empty;

		// Token: 0x04000002 RID: 2
		private int _lastMaidCount;

		// Token: 0x04000003 RID: 3
		private MPN[] checkMPNs;

		// Token: 0x0200000F RID: 15
		public class PropFileName
		{
			// Token: 0x0600006A RID: 106 RVA: 0x000085DC File Offset: 0x000067DC
			public PropFileName(int rid, string filename, string tmpFileName)
			{
				this.FileNameRID = rid;
				this.FileName = filename;
				this.TempFileName = tmpFileName;
			}

			// Token: 0x0400006D RID: 109
			public int FileNameRID;

			// Token: 0x0400006E RID: 110
			public string FileName;

			// Token: 0x0400006F RID: 111
			public string TempFileName;
		}
	}
}
