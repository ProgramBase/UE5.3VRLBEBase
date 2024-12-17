﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureSourceFormat")]
	public enum ETextureSourceFormat : byte
	{
		TSF_Invalid = 0,
		TSF_G8 = 1,
		TSF_BGRA8 = 2,
		TSF_BGRE8 = 3,
		TSF_RGBA16 = 4,
		TSF_RGBA16F = 5,
		TSF_RGBA8_DEPRECATED = 6,
		TSF_RGBE8_DEPRECATED = 7,
		TSF_G16 = 8,
		TSF_RGBA32F = 9,
		TSF_R16F = 10,
		TSF_R32F = 11,
	}
}