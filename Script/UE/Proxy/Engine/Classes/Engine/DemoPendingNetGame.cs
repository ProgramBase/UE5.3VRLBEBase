using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DemoPendingNetGame")]
	public partial class UDemoPendingNetGame : UPendingNetGame, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DemoPendingNetGame");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}