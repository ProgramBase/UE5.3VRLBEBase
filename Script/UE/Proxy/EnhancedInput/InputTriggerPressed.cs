using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputTriggerPressed")]
	public partial class UInputTriggerPressed : UInputTrigger, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.InputTriggerPressed");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}