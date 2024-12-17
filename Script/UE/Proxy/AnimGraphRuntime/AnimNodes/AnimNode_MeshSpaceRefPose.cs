using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_MeshSpaceRefPose")]
	public partial class FAnimNode_MeshSpaceRefPose : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_MeshSpaceRefPose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_MeshSpaceRefPose()
		{
		}

		public static bool operator ==(FAnimNode_MeshSpaceRefPose A, FAnimNode_MeshSpaceRefPose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_MeshSpaceRefPose A, FAnimNode_MeshSpaceRefPose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_MeshSpaceRefPose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}