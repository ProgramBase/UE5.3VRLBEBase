﻿using Script.CoreUObject;
using Script.Library;

namespace Script.MessagingRpc
{
	[PathName("/Script/MessagingRpc.RpcMessage")]
	public partial class FRpcMessage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MessagingRpc.RpcMessage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRpcMessage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRpcMessage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRpcMessage A, FRpcMessage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRpcMessage A, FRpcMessage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRpcMessage;

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