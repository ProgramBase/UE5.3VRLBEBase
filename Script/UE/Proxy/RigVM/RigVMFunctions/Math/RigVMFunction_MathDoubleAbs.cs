using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleAbs")]
	public partial class FRigVMFunction_MathDoubleAbs : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleAbs");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleAbs()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleAbs A, FRigVMFunction_MathDoubleAbs B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleAbs A, FRigVMFunction_MathDoubleAbs B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleAbs;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}