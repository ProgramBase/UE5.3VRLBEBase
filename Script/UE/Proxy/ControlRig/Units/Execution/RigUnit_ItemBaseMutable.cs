using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_ItemBaseMutable")]
	public partial class FRigUnit_ItemBaseMutable : FRigUnitMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_ItemBaseMutable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ItemBaseMutable()
		{
		}

		public static bool operator ==(FRigUnit_ItemBaseMutable A, FRigUnit_ItemBaseMutable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ItemBaseMutable A, FRigUnit_ItemBaseMutable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ItemBaseMutable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}