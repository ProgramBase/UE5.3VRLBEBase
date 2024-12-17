using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DebugDrawService")]
	public partial class UDebugDrawService : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DebugDrawService");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}