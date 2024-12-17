using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_BlendSpaceGraph")]
	public partial class FAnimNode_BlendSpaceGraph : FAnimNode_BlendSpaceGraphBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_BlendSpaceGraph");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_BlendSpaceGraph()
		{
		}

		public static bool operator ==(FAnimNode_BlendSpaceGraph A, FAnimNode_BlendSpaceGraph B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_BlendSpaceGraph A, FAnimNode_BlendSpaceGraph B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_BlendSpaceGraph;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}