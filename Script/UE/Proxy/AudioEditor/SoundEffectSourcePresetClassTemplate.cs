using Script.CoreUObject;
using Script.GameProjectGeneration;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundEffectSourcePresetClassTemplate")]
	public partial class USoundEffectSourcePresetClassTemplate : UClassTemplate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundEffectSourcePresetClassTemplate");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}