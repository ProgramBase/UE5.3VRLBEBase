using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputModifierScaleByDeltaTime")]
	public partial class UInputModifierScaleByDeltaTime : UInputModifier, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.InputModifierScaleByDeltaTime");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}