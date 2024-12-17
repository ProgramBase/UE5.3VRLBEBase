using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_Subtract_VectorVector")]
	public partial class FRigUnit_Subtract_VectorVector : FRigUnit_BinaryVectorOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_Subtract_VectorVector");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_Subtract_VectorVector()
		{
		}

		public static bool operator ==(FRigUnit_Subtract_VectorVector A, FRigUnit_Subtract_VectorVector B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_Subtract_VectorVector A, FRigUnit_Subtract_VectorVector B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_Subtract_VectorVector;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}