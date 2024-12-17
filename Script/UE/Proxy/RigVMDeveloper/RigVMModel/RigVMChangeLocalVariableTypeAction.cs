using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMChangeLocalVariableTypeAction")]
	public partial class FRigVMChangeLocalVariableTypeAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMChangeLocalVariableTypeAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMChangeLocalVariableTypeAction()
		{
		}

		public static bool operator ==(FRigVMChangeLocalVariableTypeAction A, FRigVMChangeLocalVariableTypeAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMChangeLocalVariableTypeAction A, FRigVMChangeLocalVariableTypeAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMChangeLocalVariableTypeAction;

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

		public FString CPPType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CPPType, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CPPType, __InBuffer);
				}
			}
		}

		public UObject CPPTypeObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CPPTypeObject, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CPPTypeObject, __InBuffer);
				}
			}
		}

		private static uint __LocalVariable = 0;

		private static uint __CPPType = 0;

		private static uint __CPPTypeObject = 0;

	}
}