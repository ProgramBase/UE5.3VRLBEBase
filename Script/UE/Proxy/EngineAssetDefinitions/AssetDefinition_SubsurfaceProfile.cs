﻿using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_SubsurfaceProfile")]
	public partial class UAssetDefinition_SubsurfaceProfile : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_SubsurfaceProfile");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}