﻿using Script.CoreUObject;
using Script.Library;

namespace Script.ClothingSystemRuntimeCommon
{
	[PathName("/Script/ClothingSystemRuntimeCommon.ClothingAssetCustomData")]
	public partial class UClothingAssetCustomData : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothingSystemRuntimeCommon.ClothingAssetCustomData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}