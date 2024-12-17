using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_MultiplyTransform")]
	public partial class FRigUnit_MultiplyTransform : FRigUnit_BinaryTransformOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_MultiplyTransform");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_MultiplyTransform()
		{
		}

		public static bool operator ==(FRigUnit_MultiplyTransform A, FRigUnit_MultiplyTransform B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_MultiplyTransform A, FRigUnit_MultiplyTransform B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_MultiplyTransform;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}