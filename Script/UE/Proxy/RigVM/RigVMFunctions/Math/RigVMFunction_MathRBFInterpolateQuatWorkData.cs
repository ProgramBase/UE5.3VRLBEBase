using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathRBFInterpolateQuatWorkData")]
	public partial class FRigVMFunction_MathRBFInterpolateQuatWorkData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathRBFInterpolateQuatWorkData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathRBFInterpolateQuatWorkData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMFunction_MathRBFInterpolateQuatWorkData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMFunction_MathRBFInterpolateQuatWorkData A, FRigVMFunction_MathRBFInterpolateQuatWorkData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathRBFInterpolateQuatWorkData A, FRigVMFunction_MathRBFInterpolateQuatWorkData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathRBFInterpolateQuatWorkData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}