using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputTriggerChordBlocker")]
	public partial class UInputTriggerChordBlocker : UInputTriggerChordAction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.InputTriggerChordBlocker");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}