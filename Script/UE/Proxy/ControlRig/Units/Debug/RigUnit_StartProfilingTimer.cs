using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_StartProfilingTimer")]
	public partial class FRigUnit_StartProfilingTimer : FRigVMFunction_DebugBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_StartProfilingTimer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_StartProfilingTimer()
		{
		}

		public static bool operator ==(FRigUnit_StartProfilingTimer A, FRigUnit_StartProfilingTimer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_StartProfilingTimer A, FRigUnit_StartProfilingTimer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_StartProfilingTimer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}