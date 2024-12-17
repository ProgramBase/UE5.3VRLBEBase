using Script.CoreUObject;
using Script.Library;
using Script.NetCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionDestructibleHLODState")]
	public partial class FWorldPartitionDestructibleHLODState : FFastArraySerializer, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.WorldPartitionDestructibleHLODState");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWorldPartitionDestructibleHLODState()
		{
		}

		public static bool operator ==(FWorldPartitionDestructibleHLODState A, FWorldPartitionDestructibleHLODState B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWorldPartitionDestructibleHLODState A, FWorldPartitionDestructibleHLODState B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWorldPartitionDestructibleHLODState;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FWorldPartitionDestructibleHLODDamagedActorState> DamagedActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DamagedActors, __ReturnBuffer);

					return *(TArray<FWorldPartitionDestructibleHLODDamagedActorState>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DamagedActors, __InBuffer);
				}
			}
		}

		public UWorldPartitionDestructibleHLODComponent OwnerComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OwnerComponent, __ReturnBuffer);

					return *(UWorldPartitionDestructibleHLODComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OwnerComponent, __InBuffer);
				}
			}
		}

		private static uint __DamagedActors = 0;

		private static uint __OwnerComponent = 0;

	}
}