﻿using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LevelExporterFBX")]
	public partial class ULevelExporterFBX : UExporterFBX, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LevelExporterFBX");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}