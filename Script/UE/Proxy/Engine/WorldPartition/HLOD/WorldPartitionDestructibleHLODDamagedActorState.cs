using Script.CoreUObject;
using Script.Library;
using Script.NetCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionDestructibleHLODDamagedActorState")]
	public partial class FWorldPartitionDestructibleHLODDamagedActorState : FFastArraySerializerItem, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.WorldPartitionDestructibleHLODDamagedActorState");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWorldPartitionDestructibleHLODDamagedActorState()
		{
		}

		public static bool operator ==(FWorldPartitionDestructibleHLODDamagedActorState A, FWorldPartitionDestructibleHLODDamagedActorState B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWorldPartitionDestructibleHLODDamagedActorState A, FWorldPartitionDestructibleHLODDamagedActorState B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWorldPartitionDestructibleHLODDamagedActorState;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int ActorIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorIndex, __InBuffer);
				}
			}
		}

		public byte ActorHealth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorHealth, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorHealth, __InBuffer);
				}
			}
		}

		private static uint __ActorIndex = 0;

		private static uint __ActorHealth = 0;

	}
}