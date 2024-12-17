using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputTriggerDown")]
	public partial class UInputTriggerDown : UInputTrigger, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.InputTriggerDown");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}