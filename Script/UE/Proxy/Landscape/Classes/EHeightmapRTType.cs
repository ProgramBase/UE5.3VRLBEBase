﻿using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.EHeightmapRTType")]
	public enum EHeightmapRTType : long
	{
		HeightmapRT_CombinedAtlas = 0,
		HeightmapRT_CombinedNonAtlas = 1,
		HeightmapRT_Scratch1 = 2,
		HeightmapRT_Scratch2 = 3,
		HeightmapRT_Scratch3 = 4,
		HeightmapRT_Mip1 = 5,
		HeightmapRT_Mip2 = 6,
		HeightmapRT_Mip3 = 7,
		HeightmapRT_Mip4 = 8,
		HeightmapRT_Mip5 = 9,
		HeightmapRT_Mip6 = 10,
		HeightmapRT_Mip7 = 11,
		HeightmapRT_Count = 12,
	}
}