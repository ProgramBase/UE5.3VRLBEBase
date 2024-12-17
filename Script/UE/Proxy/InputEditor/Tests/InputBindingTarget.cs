using Script.CoreUObject;
using Script.Library;

namespace Script.InputEditor
{
	[PathName("/Script/InputEditor.InputBindingTarget")]
	public partial class UInputBindingTarget : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputEditor.InputBindingTarget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}