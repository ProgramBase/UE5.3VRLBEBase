using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigMultiParentElement")]
	public partial class FRigMultiParentElement : FRigTransformElement, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigMultiParentElement");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigMultiParentElement()
		{
		}

		public static bool operator ==(FRigMultiParentElement A, FRigMultiParentElement B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigMultiParentElement A, FRigMultiParentElement B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigMultiParentElement;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}