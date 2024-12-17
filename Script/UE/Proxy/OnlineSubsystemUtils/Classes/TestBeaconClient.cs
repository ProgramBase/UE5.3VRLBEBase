using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.TestBeaconClient")]
	public partial class ATestBeaconClient : AOnlineBeaconClient, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.TestBeaconClient");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ServerPong()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ServerPong);
			}
		}

		public virtual void ClientPing()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientPing);
			}
		}

		private static uint __ServerPong = 0;

		private static uint __ClientPing = 0;
	}
}