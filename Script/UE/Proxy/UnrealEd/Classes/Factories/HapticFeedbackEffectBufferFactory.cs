using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.HapticFeedbackEffectBufferFactory")]
	public partial class UHapticFeedbackEffectBufferFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.HapticFeedbackEffectBufferFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}