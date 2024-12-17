using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputTriggerReleased")]
	public partial class UInputTriggerReleased : UInputTrigger, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.InputTriggerReleased");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}