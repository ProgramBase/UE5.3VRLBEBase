using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_ModifyBoneTransforms_WorkData")]
	public partial class FRigUnit_ModifyBoneTransforms_WorkData : FRigUnit_ModifyTransforms_WorkData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_ModifyBoneTransforms_WorkData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ModifyBoneTransforms_WorkData()
		{
		}

		public static bool operator ==(FRigUnit_ModifyBoneTransforms_WorkData A, FRigUnit_ModifyBoneTransforms_WorkData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ModifyBoneTransforms_WorkData A, FRigUnit_ModifyBoneTransforms_WorkData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ModifyBoneTransforms_WorkData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}