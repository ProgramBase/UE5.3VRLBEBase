using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.BlendSpaceReference")]
	public partial class FBlendSpaceReference : FAnimNodeReference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.BlendSpaceReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlendSpaceReference()
		{
		}

		public static bool operator ==(FBlendSpaceReference A, FBlendSpaceReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlendSpaceReference A, FBlendSpaceReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlendSpaceReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}