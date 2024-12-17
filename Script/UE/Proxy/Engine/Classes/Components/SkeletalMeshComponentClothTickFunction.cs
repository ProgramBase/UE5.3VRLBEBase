using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletalMeshComponentClothTickFunction")]
	public partial class FSkeletalMeshComponentClothTickFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkeletalMeshComponentClothTickFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkeletalMeshComponentClothTickFunction()
		{
		}

		public static bool operator ==(FSkeletalMeshComponentClothTickFunction A, FSkeletalMeshComponentClothTickFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkeletalMeshComponentClothTickFunction A, FSkeletalMeshComponentClothTickFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkeletalMeshComponentClothTickFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}