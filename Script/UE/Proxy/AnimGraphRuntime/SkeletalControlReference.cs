using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.SkeletalControlReference")]
	public partial class FSkeletalControlReference : FAnimNodeReference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.SkeletalControlReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkeletalControlReference()
		{
		}

		public static bool operator ==(FSkeletalControlReference A, FSkeletalControlReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkeletalControlReference A, FSkeletalControlReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkeletalControlReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}