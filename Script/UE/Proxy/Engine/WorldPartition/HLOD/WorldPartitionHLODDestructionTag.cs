using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionHLODDestructionTag")]
	public partial class FWorldPartitionHLODDestructionTag : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.WorldPartitionHLODDestructionTag");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWorldPartitionHLODDestructionTag() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWorldPartitionHLODDestructionTag() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWorldPartitionHLODDestructionTag A, FWorldPartitionHLODDestructionTag B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWorldPartitionHLODDestructionTag A, FWorldPartitionHLODDestructionTag B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWorldPartitionHLODDestructionTag;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UWorldPartitionDestructibleHLODComponent HLODDestructionComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HLODDestructionComponent, __ReturnBuffer);

					return *(UWorldPartitionDestructibleHLODComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HLODDestructionComponent, __InBuffer);
				}
			}
		}

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

		private static uint __HLODDestructionComponent = 0;

		private static uint __ActorIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}