﻿using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.AssetDefinition_SoundBase")]
	public partial class UAssetDefinition_SoundBase : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.AssetDefinition_SoundBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}