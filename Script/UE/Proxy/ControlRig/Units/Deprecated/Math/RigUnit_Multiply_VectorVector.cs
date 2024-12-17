using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_Multiply_VectorVector")]
	public partial class FRigUnit_Multiply_VectorVector : FRigUnit_BinaryVectorOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_Multiply_VectorVector");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_Multiply_VectorVector()
		{
		}

		public static bool operator ==(FRigUnit_Multiply_VectorVector A, FRigUnit_Multiply_VectorVector B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_Multiply_VectorVector A, FRigUnit_Multiply_VectorVector B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_Multiply_VectorVector;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}