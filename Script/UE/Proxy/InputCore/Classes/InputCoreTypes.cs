using Script.CoreUObject;
using Script.Library;

namespace Script.InputCore
{
	[PathName("/Script/InputCore.InputCoreTypes")]
	public partial class UInputCoreTypes : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputCore.InputCoreTypes");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}