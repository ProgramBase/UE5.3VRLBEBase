using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.TestBeaconHost")]
	public partial class ATestBeaconHost : AOnlineBeaconHostObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.TestBeaconHost");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}