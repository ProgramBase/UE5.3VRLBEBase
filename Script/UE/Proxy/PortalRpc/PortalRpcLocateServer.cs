using Script.CoreUObject;
using Script.Library;

namespace Script.PortalRpc
{
	[PathName("/Script/PortalRpc.PortalRpcLocateServer")]
	public partial class FPortalRpcLocateServer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PortalRpc.PortalRpcLocateServer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPortalRpcLocateServer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPortalRpcLocateServer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPortalRpcLocateServer A, FPortalRpcLocateServer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPortalRpcLocateServer A, FPortalRpcLocateServer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPortalRpcLocateServer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid ProductId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProductId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProductId, __InBuffer);
				}
			}
		}

		public FString ProductVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProductVersion, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProductVersion, __InBuffer);
				}
			}
		}

		public FString HostMacAddress
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HostMacAddress, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HostMacAddress, __InBuffer);
				}
			}
		}

		public FString HostUserId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HostUserId, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HostUserId, __InBuffer);
				}
			}
		}

		private static uint __ProductId = 0;

		private static uint __ProductVersion = 0;

		private static uint __HostMacAddress = 0;

		private static uint __HostUserId = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}