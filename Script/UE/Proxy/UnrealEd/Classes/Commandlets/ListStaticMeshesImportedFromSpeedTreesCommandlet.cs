﻿using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ListStaticMeshesImportedFromSpeedTreesCommandlet")]
	public partial class UListStaticMeshesImportedFromSpeedTreesCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ListStaticMeshesImportedFromSpeedTreesCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}