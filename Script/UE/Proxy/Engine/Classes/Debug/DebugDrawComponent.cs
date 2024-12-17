using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DebugDrawComponent")]
	public partial class UDebugDrawComponent : UPrimitiveComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DebugDrawComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}