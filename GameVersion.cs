﻿namespace ACT.DFAssist
{
	class GameVersion
	{
		public int Index { get; set; }
		public string Name { get; set; }

		//
		public GameVersion()
		{
		}

		//
		public GameVersion(int index, string name)
		{
			Index = index;
			Name = name;
		}

		// 버전 목록
		public static readonly GameVersion[] Versions = new GameVersion[]
		{
			/* 20210427 */ new GameVersion(0, "5.5hf"),
			/* 20210112 */ new GameVersion(1, "KR 5.31"),
		};
	}
}
