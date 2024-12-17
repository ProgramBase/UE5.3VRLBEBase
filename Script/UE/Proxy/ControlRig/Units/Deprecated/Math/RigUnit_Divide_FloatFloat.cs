using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_Divide_FloatFloat")]
	public partial class FRigUnit_Divide_FloatFloat : FRigUnit_BinaryFloatOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_Divide_FloatFloat");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_Divide_FloatFloat()
		{
		}

		public static bool operator ==(FRigUnit_Divide_FloatFloat A, FRigUnit_Divide_FloatFloat B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_Divide_FloatFloat A, FRigUnit_Divide_FloatFloat B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_Divide_FloatFloat;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}