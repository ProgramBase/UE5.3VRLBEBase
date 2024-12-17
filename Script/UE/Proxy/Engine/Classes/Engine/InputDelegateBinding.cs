using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputDelegateBinding")]
	public partial class UInputDelegateBinding : UDynamicBlueprintBinding, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputDelegateBinding");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}