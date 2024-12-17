using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SimulatedClientNetConnection")]
	public partial class USimulatedClientNetConnection : UNetConnection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SimulatedClientNetConnection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}