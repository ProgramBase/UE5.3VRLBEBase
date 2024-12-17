using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputModifierSmooth")]
	public partial class UInputModifierSmooth : UInputModifier, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.InputModifierSmooth");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}