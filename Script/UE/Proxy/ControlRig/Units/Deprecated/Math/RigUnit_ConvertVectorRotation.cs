using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_ConvertVectorRotation")]
	public partial class FRigUnit_ConvertVectorRotation : FRigUnit_ConvertRotation, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_ConvertVectorRotation");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ConvertVectorRotation()
		{
		}

		public static bool operator ==(FRigUnit_ConvertVectorRotation A, FRigUnit_ConvertVectorRotation B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ConvertVectorRotation A, FRigUnit_ConvertVectorRotation B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ConvertVectorRotation;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}