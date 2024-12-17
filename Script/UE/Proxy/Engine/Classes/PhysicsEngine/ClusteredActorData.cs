using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ClusteredActorData")]
	public partial class FClusteredActorData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ClusteredActorData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FClusteredActorData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FClusteredActorData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FClusteredActorData A, FClusteredActorData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FClusteredActorData A, FClusteredActorData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FClusteredActorData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSet<TWeakObjectPtr<UPrimitiveComponent>> Components
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Components, __ReturnBuffer);

					return *(TSet<TWeakObjectPtr<UPrimitiveComponent>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Components, __InBuffer);
				}
			}
		}

		public bool bWasReplicatingMovement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bWasReplicatingMovement, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bWasReplicatingMovement, __InBuffer);
				}
			}
		}

		private static uint __Components = 0;

		private static uint __bWasReplicatingMovement = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}