using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundEffectSourcePreset")]
	public partial class USoundEffectSourcePreset : USoundEffectPreset, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundEffectSourcePreset");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}