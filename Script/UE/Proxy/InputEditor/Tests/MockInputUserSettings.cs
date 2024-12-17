using Script.CoreUObject;
using Script.EnhancedInput;
using Script.Library;

namespace Script.InputEditor
{
	[PathName("/Script/InputEditor.MockInputUserSettings")]
	public partial class UMockInputUserSettings : UEnhancedInputUserSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputEditor.MockInputUserSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}