using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.HapticFeedbackEffectSoundWaveFactory")]
	public partial class UHapticFeedbackEffectSoundWaveFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.HapticFeedbackEffectSoundWaveFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}