using Script.CoreUObject;
using Script.Library;

namespace Script.UdpMessaging
{
	[PathName("/Script/UdpMessaging.UdpMockMessage")]
	public partial class FUdpMockMessage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UdpMessaging.UdpMockMessage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUdpMockMessage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FUdpMockMessage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FUdpMockMessage A, FUdpMockMessage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUdpMockMessage A, FUdpMockMessage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUdpMockMessage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<byte> Data
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Data, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Data, __InBuffer);
				}
			}
		}

		private static uint __Data = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}