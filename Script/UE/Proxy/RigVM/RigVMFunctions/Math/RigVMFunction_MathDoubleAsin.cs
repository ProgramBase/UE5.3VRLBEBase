using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleAsin")]
	public partial class FRigVMFunction_MathDoubleAsin : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleAsin");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleAsin()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleAsin A, FRigVMFunction_MathDoubleAsin B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleAsin A, FRigVMFunction_MathDoubleAsin B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleAsin;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}