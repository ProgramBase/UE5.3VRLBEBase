using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.LayeredBoneBlendReference")]
	public partial class FLayeredBoneBlendReference : FAnimNodeReference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.LayeredBoneBlendReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLayeredBoneBlendReference()
		{
		}

		public static bool operator ==(FLayeredBoneBlendReference A, FLayeredBoneBlendReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLayeredBoneBlendReference A, FLayeredBoneBlendReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLayeredBoneBlendReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}