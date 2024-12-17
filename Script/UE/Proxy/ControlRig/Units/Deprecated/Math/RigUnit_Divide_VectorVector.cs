using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_Divide_VectorVector")]
	public partial class FRigUnit_Divide_VectorVector : FRigUnit_BinaryVectorOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_Divide_VectorVector");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_Divide_VectorVector()
		{
		}

		public static bool operator ==(FRigUnit_Divide_VectorVector A, FRigUnit_Divide_VectorVector B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_Divide_VectorVector A, FRigUnit_Divide_VectorVector B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_Divide_VectorVector;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}