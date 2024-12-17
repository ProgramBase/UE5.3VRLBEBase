using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintFunctionLibrary")]
	public partial class UBlueprintFunctionLibrary : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BlueprintFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}