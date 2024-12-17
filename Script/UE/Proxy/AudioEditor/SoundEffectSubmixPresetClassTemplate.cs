using Script.CoreUObject;
using Script.GameProjectGeneration;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundEffectSubmixPresetClassTemplate")]
	public partial class USoundEffectSubmixPresetClassTemplate : UClassTemplate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundEffectSubmixPresetClassTemplate");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}