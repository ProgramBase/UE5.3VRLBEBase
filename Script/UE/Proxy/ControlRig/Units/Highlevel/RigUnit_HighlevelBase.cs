using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HighlevelBase")]
	public partial class FRigUnit_HighlevelBase : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HighlevelBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HighlevelBase()
		{
		}

		public static bool operator ==(FRigUnit_HighlevelBase A, FRigUnit_HighlevelBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HighlevelBase A, FRigUnit_HighlevelBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HighlevelBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}