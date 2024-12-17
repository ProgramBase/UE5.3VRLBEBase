using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DemoNetConnection")]
	public partial class UDemoNetConnection : UNetConnection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DemoNetConnection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}