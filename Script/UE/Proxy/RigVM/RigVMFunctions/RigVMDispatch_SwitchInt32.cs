﻿using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_SwitchInt32")]
	public partial class FRigVMDispatch_SwitchInt32 : FRigVMDispatch_CoreBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_SwitchInt32");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_SwitchInt32()
		{
		}

		public static bool operator ==(FRigVMDispatch_SwitchInt32 A, FRigVMDispatch_SwitchInt32 B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_SwitchInt32 A, FRigVMDispatch_SwitchInt32 B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_SwitchInt32;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}