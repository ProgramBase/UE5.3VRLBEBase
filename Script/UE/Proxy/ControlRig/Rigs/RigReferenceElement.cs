using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigReferenceElement")]
	public partial class FRigReferenceElement : FRigSingleParentElement, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigReferenceElement");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigReferenceElement()
		{
		}

		public static bool operator ==(FRigReferenceElement A, FRigReferenceElement B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigReferenceElement A, FRigReferenceElement B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigReferenceElement;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}