using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleTan")]
	public partial class FRigVMFunction_MathDoubleTan : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleTan");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleTan()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleTan A, FRigVMFunction_MathDoubleTan B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleTan A, FRigVMFunction_MathDoubleTan B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleTan;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}