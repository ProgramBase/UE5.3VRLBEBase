using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatTan")]
	public partial class FRigVMFunction_MathFloatTan : FRigVMFunction_MathFloatUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatTan");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatTan()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatTan A, FRigVMFunction_MathFloatTan B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatTan A, FRigVMFunction_MathFloatTan B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatTan;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}