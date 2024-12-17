using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletalMeshComponentEndPhysicsTickFunction")]
	public partial class FSkeletalMeshComponentEndPhysicsTickFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkeletalMeshComponentEndPhysicsTickFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkeletalMeshComponentEndPhysicsTickFunction()
		{
		}

		public static bool operator ==(FSkeletalMeshComponentEndPhysicsTickFunction A, FSkeletalMeshComponentEndPhysicsTickFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkeletalMeshComponentEndPhysicsTickFunction A, FSkeletalMeshComponentEndPhysicsTickFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkeletalMeshComponentEndPhysicsTickFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}