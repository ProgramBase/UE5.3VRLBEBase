using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigExecuteContext")]
	public partial class FControlRigExecuteContext : FRigVMExecuteContext, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.ControlRigExecuteContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigExecuteContext()
		{
		}

		public static bool operator ==(FControlRigExecuteContext A, FControlRigExecuteContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigExecuteContext A, FControlRigExecuteContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigExecuteContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}