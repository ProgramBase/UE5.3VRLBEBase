﻿using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_PhysicalMaterial")]
	public partial class UAssetDefinition_PhysicalMaterial : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_PhysicalMaterial");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}