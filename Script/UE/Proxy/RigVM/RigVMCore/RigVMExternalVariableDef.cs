using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMExternalVariableDef")]
	public partial class FRigVMExternalVariableDef : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMExternalVariableDef");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMExternalVariableDef() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMExternalVariableDef() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMExternalVariableDef A, FRigVMExternalVariableDef B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMExternalVariableDef A, FRigVMExternalVariableDef B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMExternalVariableDef;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}