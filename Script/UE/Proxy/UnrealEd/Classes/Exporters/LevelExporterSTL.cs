﻿using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LevelExporterSTL")]
	public partial class ULevelExporterSTL : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LevelExporterSTL");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}