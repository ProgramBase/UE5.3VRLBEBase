using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.BlendSpacePlayerReference")]
	public partial class FBlendSpacePlayerReference : FAnimNodeReference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.BlendSpacePlayerReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlendSpacePlayerReference()
		{
		}

		public static bool operator ==(FBlendSpacePlayerReference A, FBlendSpacePlayerReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlendSpacePlayerReference A, FBlendSpacePlayerReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlendSpacePlayerReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}