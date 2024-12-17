using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMInstructionArray")]
	public partial class FRigVMInstructionArray : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMInstructionArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMInstructionArray() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMInstructionArray() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMInstructionArray A, FRigVMInstructionArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMInstructionArray A, FRigVMInstructionArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMInstructionArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigVMInstruction> Instructions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Instructions, __ReturnBuffer);

					return *(TArray<FRigVMInstruction>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Instructions, __InBuffer);
				}
			}
		}

		private static uint __Instructions = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}