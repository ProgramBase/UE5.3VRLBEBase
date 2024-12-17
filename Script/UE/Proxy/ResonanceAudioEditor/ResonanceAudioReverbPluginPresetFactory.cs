using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ResonanceAudioEditor
{
	[PathName("/Script/ResonanceAudioEditor.ResonanceAudioReverbPluginPresetFactory")]
	public partial class UResonanceAudioReverbPluginPresetFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ResonanceAudioEditor.ResonanceAudioReverbPluginPresetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}