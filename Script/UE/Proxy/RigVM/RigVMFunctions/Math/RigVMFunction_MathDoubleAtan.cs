using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleAtan")]
	public partial class FRigVMFunction_MathDoubleAtan : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleAtan");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleAtan()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleAtan A, FRigVMFunction_MathDoubleAtan B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleAtan A, FRigVMFunction_MathDoubleAtan B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleAtan;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}