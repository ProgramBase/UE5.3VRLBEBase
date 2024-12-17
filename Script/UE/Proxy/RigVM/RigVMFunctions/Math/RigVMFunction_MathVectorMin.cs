﻿using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorMin")]
	public partial class FRigVMFunction_MathVectorMin : FRigVMFunction_MathVectorBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorMin");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorMin()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorMin A, FRigVMFunction_MathVectorMin B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorMin A, FRigVMFunction_MathVectorMin B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorMin;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}