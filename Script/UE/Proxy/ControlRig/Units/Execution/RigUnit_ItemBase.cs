using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_ItemBase")]
	public partial class FRigUnit_ItemBase : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_ItemBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ItemBase()
		{
		}

		public static bool operator ==(FRigUnit_ItemBase A, FRigUnit_ItemBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ItemBase A, FRigUnit_ItemBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ItemBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}