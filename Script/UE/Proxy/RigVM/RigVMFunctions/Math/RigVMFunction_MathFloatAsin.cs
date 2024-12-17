using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatAsin")]
	public partial class FRigVMFunction_MathFloatAsin : FRigVMFunction_MathFloatUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatAsin");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatAsin()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatAsin A, FRigVMFunction_MathFloatAsin B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatAsin A, FRigVMFunction_MathFloatAsin B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatAsin;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}