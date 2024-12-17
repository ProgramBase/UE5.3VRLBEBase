using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.ObjectReplicationBridgePrioritizerConfig")]
	public partial class FObjectReplicationBridgePrioritizerConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.ObjectReplicationBridgePrioritizerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FObjectReplicationBridgePrioritizerConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FObjectReplicationBridgePrioritizerConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FObjectReplicationBridgePrioritizerConfig A, FObjectReplicationBridgePrioritizerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FObjectReplicationBridgePrioritizerConfig A, FObjectReplicationBridgePrioritizerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FObjectReplicationBridgePrioritizerConfig;

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

		public FName PrioritizerName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PrioritizerName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PrioritizerName, __InBuffer);
				}
			}
		}

		public bool bForceEnableOnAllInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bForceEnableOnAllInstances, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bForceEnableOnAllInstances, __InBuffer);
				}
			}
		}

		private static uint __ClassName = 0;

		private static uint __PrioritizerName = 0;

		private static uint __bForceEnableOnAllInstances = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}