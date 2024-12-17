﻿using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathIntMod")]
	public partial class FRigVMFunction_MathIntMod : FRigVMFunction_MathIntBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathIntMod");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathIntMod()
		{
		}

		public static bool operator ==(FRigVMFunction_MathIntMod A, FRigVMFunction_MathIntMod B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathIntMod A, FRigVMFunction_MathIntMod B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathIntMod;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}