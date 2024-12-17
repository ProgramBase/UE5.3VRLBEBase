using Script.CoreUObject;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.PendingDelayedSpawn")]
	public partial class FPendingDelayedSpawn : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FunctionalTesting.PendingDelayedSpawn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPendingDelayedSpawn() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPendingDelayedSpawn() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPendingDelayedSpawn A, FPendingDelayedSpawn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPendingDelayedSpawn A, FPendingDelayedSpawn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPendingDelayedSpawn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}