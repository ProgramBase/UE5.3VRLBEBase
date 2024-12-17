using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionActorFilter")]
	public partial class FWorldPartitionActorFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.WorldPartitionActorFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWorldPartitionActorFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWorldPartitionActorFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWorldPartitionActorFilter A, FWorldPartitionActorFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWorldPartitionActorFilter A, FWorldPartitionActorFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWorldPartitionActorFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}