using Script.CoreUObject;
using Script.Library;

namespace Script.MessagingRpc
{
	[PathName("/Script/MessagingRpc.MessageRpcUnhandled")]
	public partial class FMessageRpcUnhandled : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MessagingRpc.MessageRpcUnhandled");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMessageRpcUnhandled() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMessageRpcUnhandled() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMessageRpcUnhandled A, FMessageRpcUnhandled B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMessageRpcUnhandled A, FMessageRpcUnhandled B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMessageRpcUnhandled;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid CallId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CallId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CallId, __InBuffer);
				}
			}
		}

		private static uint __CallId = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}