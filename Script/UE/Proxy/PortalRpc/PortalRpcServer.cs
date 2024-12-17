using Script.CoreUObject;
using Script.Library;

namespace Script.PortalRpc
{
	[PathName("/Script/PortalRpc.PortalRpcServer")]
	public partial class FPortalRpcServer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PortalRpc.PortalRpcServer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPortalRpcServer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPortalRpcServer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPortalRpcServer A, FPortalRpcServer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPortalRpcServer A, FPortalRpcServer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPortalRpcServer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ServerAddress
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ServerAddress, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ServerAddress, __InBuffer);
				}
			}
		}

		private static uint __ServerAddress = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}