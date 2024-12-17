using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigCurveElement")]
	public partial class FRigCurveElement : FRigBaseElement, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigCurveElement");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigCurveElement()
		{
		}

		public static bool operator ==(FRigCurveElement A, FRigCurveElement B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigCurveElement A, FRigCurveElement B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigCurveElement;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}