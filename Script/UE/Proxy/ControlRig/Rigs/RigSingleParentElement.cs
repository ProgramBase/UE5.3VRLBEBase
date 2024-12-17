using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigSingleParentElement")]
	public partial class FRigSingleParentElement : FRigTransformElement, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigSingleParentElement");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigSingleParentElement()
		{
		}

		public static bool operator ==(FRigSingleParentElement A, FRigSingleParentElement B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigSingleParentElement A, FRigSingleParentElement B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigSingleParentElement;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}