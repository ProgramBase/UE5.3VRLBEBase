using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigAnimInstanceProxy")]
	public partial class FControlRigAnimInstanceProxy : FAnimInstanceProxy, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.ControlRigAnimInstanceProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigAnimInstanceProxy()
		{
		}

		public static bool operator ==(FControlRigAnimInstanceProxy A, FControlRigAnimInstanceProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigAnimInstanceProxy A, FControlRigAnimInstanceProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigAnimInstanceProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}