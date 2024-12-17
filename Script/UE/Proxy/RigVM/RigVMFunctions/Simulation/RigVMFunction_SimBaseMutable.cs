﻿using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_SimBaseMutable")]
	public partial class FRigVMFunction_SimBaseMutable : FRigVMStructMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_SimBaseMutable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_SimBaseMutable()
		{
		}

		public static bool operator ==(FRigVMFunction_SimBaseMutable A, FRigVMFunction_SimBaseMutable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_SimBaseMutable A, FRigVMFunction_SimBaseMutable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_SimBaseMutable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}