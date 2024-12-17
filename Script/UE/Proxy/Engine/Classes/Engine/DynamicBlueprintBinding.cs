using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DynamicBlueprintBinding")]
	public partial class UDynamicBlueprintBinding : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DynamicBlueprintBinding");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}