using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_GetRelativeTransform")]
	public partial class FRigUnit_GetRelativeTransform : FRigUnit_BinaryTransformOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_GetRelativeTransform");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_GetRelativeTransform()
		{
		}

		public static bool operator ==(FRigUnit_GetRelativeTransform A, FRigUnit_GetRelativeTransform B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_GetRelativeTransform A, FRigUnit_GetRelativeTransform B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_GetRelativeTransform;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}