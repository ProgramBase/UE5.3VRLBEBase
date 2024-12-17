using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.AnimNode_PreviewRetargetPose")]
	public partial class FAnimNode_PreviewRetargetPose : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IKRigEditor.AnimNode_PreviewRetargetPose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_PreviewRetargetPose()
		{
		}

		public static bool operator ==(FAnimNode_PreviewRetargetPose A, FAnimNode_PreviewRetargetPose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_PreviewRetargetPose A, FAnimNode_PreviewRetargetPose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_PreviewRetargetPose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}