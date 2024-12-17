using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HighlevelBaseMutable")]
	public partial class FRigUnit_HighlevelBaseMutable : FRigUnitMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HighlevelBaseMutable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HighlevelBaseMutable()
		{
		}

		public static bool operator ==(FRigUnit_HighlevelBaseMutable A, FRigUnit_HighlevelBaseMutable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HighlevelBaseMutable A, FRigUnit_HighlevelBaseMutable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HighlevelBaseMutable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}