using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundEffectPreset")]
	public partial class USoundEffectPreset : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundEffectPreset");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}