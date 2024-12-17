using Script.CoreUObject;
using Script.EnhancedInput;
using Script.Library;

namespace Script.InputEditor
{
	[PathName("/Script/InputEditor.TestMappableKeysAction")]
	public partial class UTestMappableKeysAction : UInputAction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputEditor.TestMappableKeysAction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}