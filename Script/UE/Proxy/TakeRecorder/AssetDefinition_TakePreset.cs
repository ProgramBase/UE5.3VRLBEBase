using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.TakeRecorder
{
	[PathName("/Script/TakeRecorder.AssetDefinition_TakePreset")]
	public partial class UAssetDefinition_TakePreset : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorder.AssetDefinition_TakePreset");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}