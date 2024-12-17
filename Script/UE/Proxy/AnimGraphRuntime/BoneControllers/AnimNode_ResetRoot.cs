using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_ResetRoot")]
	public partial class FAnimNode_ResetRoot : FAnimNode_SkeletalControlBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_ResetRoot");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_ResetRoot()
		{
		}

		public static bool operator ==(FAnimNode_ResetRoot A, FAnimNode_ResetRoot B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_ResetRoot A, FAnimNode_ResetRoot B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_ResetRoot;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}