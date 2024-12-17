﻿using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathBoolNand2")]
	public partial class FRigVMFunction_MathBoolNand2 : FRigVMFunction_MathBoolBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathBoolNand2");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathBoolNand2()
		{
		}

		public static bool operator ==(FRigVMFunction_MathBoolNand2 A, FRigVMFunction_MathBoolNand2 B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathBoolNand2 A, FRigVMFunction_MathBoolNand2 B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathBoolNand2;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}