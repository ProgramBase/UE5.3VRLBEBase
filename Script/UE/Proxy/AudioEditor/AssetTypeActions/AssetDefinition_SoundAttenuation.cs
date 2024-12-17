using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.AssetDefinition_SoundAttenuation")]
	public partial class UAssetDefinition_SoundAttenuation : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.AssetDefinition_SoundAttenuation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}