using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.HapticFeedbackEffectCurveFactory")]
	public partial class UHapticFeedbackEffectCurveFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.HapticFeedbackEffectCurveFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}