﻿using Script.CoreUObject;

namespace Script.WaveTable
{
	[PathName("/Script/WaveTable.EWaveTableResolution")]
	public enum EWaveTableResolution : byte
	{
		None = 0,
		Res_8 = 3,
		Res_16 = 4,
		Res_32 = 5,
		Res_64 = 6,
		Res_128 = 7,
		Res_256 = 8,
		Res_512 = 9,
		Res_1024 = 10,
		Res_2048 = 11,
		Res_4096 = 12,
		Res_Max = 12,
		Maximum = 13,
	}
}