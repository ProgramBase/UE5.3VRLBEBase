using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMChangeLocalVariableDefaultValueAction")]
	public partial class FRigVMChangeLocalVariableDefaultValueAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMChangeLocalVariableDefaultValueAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMChangeLocalVariableDefaultValueAction()
		{
		}

		public static bool operator ==(FRigVMChangeLocalVariableDefaultValueAction A, FRigVMChangeLocalVariableDefaultValueAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMChangeLocalVariableDefaultValueAction A, FRigVMChangeLocalVariableDefaultValueAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMChangeLocalVariableDefaultValueAction;

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

		public FString DefaultValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __InBuffer);
				}
			}
		}

		private static uint __LocalVariable = 0;

		private static uint __DefaultValue = 0;

	}
}