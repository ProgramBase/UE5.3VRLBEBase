using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMExternalVariable")]
	public partial class FRigVMExternalVariable : FRigVMExternalVariableDef, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMExternalVariable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMExternalVariable()
		{
		}

		public static bool operator ==(FRigVMExternalVariable A, FRigVMExternalVariable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMExternalVariable A, FRigVMExternalVariable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMExternalVariable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}