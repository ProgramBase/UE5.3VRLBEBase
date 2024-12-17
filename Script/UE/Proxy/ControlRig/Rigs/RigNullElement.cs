using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigNullElement")]
	public partial class FRigNullElement : FRigMultiParentElement, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigNullElement");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigNullElement()
		{
		}

		public static bool operator ==(FRigNullElement A, FRigNullElement B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigNullElement A, FRigNullElement B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigNullElement;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}