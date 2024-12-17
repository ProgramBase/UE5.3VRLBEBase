using Script.CoreUObject;
using Script.Library;
using Script.ControlRig;

namespace Script.ControlRigSpline
{
	[PathName("/Script/ControlRigSpline.RigUnit_ControlRigSplineBase")]
	public partial class FRigUnit_ControlRigSplineBase : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigSpline.RigUnit_ControlRigSplineBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ControlRigSplineBase()
		{
		}

		public static bool operator ==(FRigUnit_ControlRigSplineBase A, FRigUnit_ControlRigSplineBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ControlRigSplineBase A, FRigUnit_ControlRigSplineBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ControlRigSplineBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}