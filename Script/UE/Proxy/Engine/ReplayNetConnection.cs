using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ReplayNetConnection")]
	public partial class UReplayNetConnection : UNetConnection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ReplayNetConnection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}