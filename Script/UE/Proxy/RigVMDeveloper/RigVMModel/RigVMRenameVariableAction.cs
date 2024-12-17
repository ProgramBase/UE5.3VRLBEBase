using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMRenameVariableAction")]
	public partial class FRigVMRenameVariableAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMRenameVariableAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMRenameVariableAction()
		{
		}

		public static bool operator ==(FRigVMRenameVariableAction A, FRigVMRenameVariableAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMRenameVariableAction A, FRigVMRenameVariableAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMRenameVariableAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString OldVariableName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OldVariableName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OldVariableName, __InBuffer);
				}
			}
		}

		public FString NewVariableName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewVariableName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewVariableName, __InBuffer);
				}
			}
		}

		private static uint __OldVariableName = 0;

		private static uint __NewVariableName = 0;

	}
}