using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundEffectSubmixPreset")]
	public partial class USoundEffectSubmixPreset : USoundEffectPreset, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundEffectSubmixPreset");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}