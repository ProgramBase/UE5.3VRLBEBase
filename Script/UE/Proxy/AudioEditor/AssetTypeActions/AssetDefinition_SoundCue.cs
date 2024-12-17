using Script.CoreUObject;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.AssetDefinition_SoundCue")]
	public partial class UAssetDefinition_SoundCue : UAssetDefinition_SoundBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.AssetDefinition_SoundCue");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}