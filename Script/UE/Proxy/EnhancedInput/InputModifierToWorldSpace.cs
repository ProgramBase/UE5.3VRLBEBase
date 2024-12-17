using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputModifierToWorldSpace")]
	public partial class UInputModifierToWorldSpace : UInputModifier, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.InputModifierToWorldSpace");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}