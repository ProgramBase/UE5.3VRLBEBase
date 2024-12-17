using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_Subtract_FloatFloat")]
	public partial class FRigUnit_Subtract_FloatFloat : FRigUnit_BinaryFloatOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_Subtract_FloatFloat");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_Subtract_FloatFloat()
		{
		}

		public static bool operator ==(FRigUnit_Subtract_FloatFloat A, FRigUnit_Subtract_FloatFloat B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_Subtract_FloatFloat A, FRigUnit_Subtract_FloatFloat B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_Subtract_FloatFloat;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}