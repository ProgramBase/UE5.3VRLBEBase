using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigDispatchFactory")]
	public partial class FRigDispatchFactory : FRigVMDispatchFactory, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigDispatchFactory");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigDispatchFactory()
		{
		}

		public static bool operator ==(FRigDispatchFactory A, FRigDispatchFactory B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigDispatchFactory A, FRigDispatchFactory B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigDispatchFactory;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}