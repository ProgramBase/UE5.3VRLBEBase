using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.OnlineBeaconClient")]
	public partial class AOnlineBeaconClient : AOnlineBeacon, IStaticClass
	{
		public AOnlineBeaconHostObject BeaconOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BeaconOwner, __ReturnBuffer);

					return *(AOnlineBeaconHostObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BeaconOwner, __InBuffer);
				}
			}
		}

		public UNetConnection BeaconConnection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BeaconConnection, __ReturnBuffer);

					return *(UNetConnection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BeaconConnection, __InBuffer);
				}
			}
		}

		public EBeaconConnectionState ConnectionState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConnectionState, __ReturnBuffer);

					return *(EBeaconConnectionState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConnectionState, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.OnlineBeaconClient");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ClientOnConnected()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientOnConnected);
			}
		}

		private static uint __BeaconOwner = 0;

		private static uint __BeaconConnection = 0;

		private static uint __ConnectionState = 0;

		private static uint __ClientOnConnected = 0;
	}
}