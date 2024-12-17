using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMAddLocalVariableAction")]
	public partial class FRigVMAddLocalVariableAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMAddLocalVariableAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMAddLocalVariableAction()
		{
		}

		public static bool operator ==(FRigVMAddLocalVariableAction A, FRigVMAddLocalVariableAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMAddLocalVariableAction A, FRigVMAddLocalVariableAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMAddLocalVariableAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigVMGraphVariableDescription LocalVariable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LocalVariable, __ReturnBuffer);

					return *(FRigVMGraphVariableDescription*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LocalVariable, __InBuffer);
				}
			}
		}

		private static uint __LocalVariable = 0;

	}
}