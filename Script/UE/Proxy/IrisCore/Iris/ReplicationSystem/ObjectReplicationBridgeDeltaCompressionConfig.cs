using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.ObjectReplicationBridgeDeltaCompressionConfig")]
	public partial class FObjectReplicationBridgeDeltaCompressionConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.ObjectReplicationBridgeDeltaCompressionConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FObjectReplicationBridgeDeltaCompressionConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FObjectReplicationBridgeDeltaCompressionConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FObjectReplicationBridgeDeltaCompressionConfig A, FObjectReplicationBridgeDeltaCompressionConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FObjectReplicationBridgeDeltaCompressionConfig A, FObjectReplicationBridgeDeltaCompressionConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FObjectReplicationBridgeDeltaCompressionConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ClassName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ClassName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ClassName, __InBuffer);
				}
			}
		}

		public bool bEnableDeltaCompression
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEnableDeltaCompression, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEnableDeltaCompression, __InBuffer);
				}
			}
		}

		private static uint __ClassName = 0;

		private static uint __bEnableDeltaCompression = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}