using Script.CoreUObject;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.AssetDefinition_SoundSourceBus")]
	public partial class UAssetDefinition_SoundSourceBus : UAssetDefinition_SoundBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.AssetDefinition_SoundSourceBus");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}