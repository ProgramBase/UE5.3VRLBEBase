using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunctionCompilationData")]
	public partial class FRigVMFunctionCompilationData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunctionCompilationData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunctionCompilationData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMFunctionCompilationData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMFunctionCompilationData A, FRigVMFunctionCompilationData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunctionCompilationData A, FRigVMFunctionCompilationData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunctionCompilationData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigVMByteCode ByteCode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ByteCode, __ReturnBuffer);

					return *(FRigVMByteCode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ByteCode, __InBuffer);
				}
			}
		}

		public TArray<FName> FunctionNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FunctionNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FunctionNames, __InBuffer);
				}
			}
		}

		public TArray<FRigVMFunctionCompilationPropertyDescription> WorkPropertyDescriptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorkPropertyDescriptions, __ReturnBuffer);

					return *(TArray<FRigVMFunctionCompilationPropertyDescription>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WorkPropertyDescriptions, __InBuffer);
				}
			}
		}

		public TArray<FRigVMFunctionCompilationPropertyPath> WorkPropertyPathDescriptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorkPropertyPathDescriptions, __ReturnBuffer);

					return *(TArray<FRigVMFunctionCompilationPropertyPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WorkPropertyPathDescriptions, __InBuffer);
				}
			}
		}

		public TArray<FRigVMFunctionCompilationPropertyDescription> LiteralPropertyDescriptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LiteralPropertyDescriptions, __ReturnBuffer);

					return *(TArray<FRigVMFunctionCompilationPropertyDescription>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LiteralPropertyDescriptions, __InBuffer);
				}
			}
		}

		public TArray<FRigVMFunctionCompilationPropertyPath> LiteralPropertyPathDescriptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LiteralPropertyPathDescriptions, __ReturnBuffer);

					return *(TArray<FRigVMFunctionCompilationPropertyPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LiteralPropertyPathDescriptions, __InBuffer);
				}
			}
		}

		public TArray<FRigVMFunctionCompilationPropertyDescription> DebugPropertyDescriptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DebugPropertyDescriptions, __ReturnBuffer);

					return *(TArray<FRigVMFunctionCompilationPropertyDescription>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DebugPropertyDescriptions, __InBuffer);
				}
			}
		}

		public TArray<FRigVMFunctionCompilationPropertyPath> DebugPropertyPathDescriptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DebugPropertyPathDescriptions, __ReturnBuffer);

					return *(TArray<FRigVMFunctionCompilationPropertyPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DebugPropertyPathDescriptions, __InBuffer);
				}
			}
		}

		public TArray<FRigVMFunctionCompilationPropertyDescription> ExternalPropertyDescriptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExternalPropertyDescriptions, __ReturnBuffer);

					return *(TArray<FRigVMFunctionCompilationPropertyDescription>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExternalPropertyDescriptions, __InBuffer);
				}
			}
		}

		public TArray<FRigVMFunctionCompilationPropertyPath> ExternalPropertyPathDescriptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExternalPropertyPathDescriptions, __ReturnBuffer);

					return *(TArray<FRigVMFunctionCompilationPropertyPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExternalPropertyPathDescriptions, __InBuffer);
				}
			}
		}

		public TMap<int, FName> ExternalRegisterIndexToVariable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExternalRegisterIndexToVariable, __ReturnBuffer);

					return *(TMap<int, FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExternalRegisterIndexToVariable, __InBuffer);
				}
			}
		}

		public TMap<FString, FRigVMOperand> Operands
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Operands, __ReturnBuffer);

					return *(TMap<FString, FRigVMOperand>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Operands, __InBuffer);
				}
			}
		}

		public uint Hash
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Hash, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Hash, __InBuffer);
				}
			}
		}

		private static uint __ByteCode = 0;

		private static uint __FunctionNames = 0;

		private static uint __WorkPropertyDescriptions = 0;

		private static uint __WorkPropertyPathDescriptions = 0;

		private static uint __LiteralPropertyDescriptions = 0;

		private static uint __LiteralPropertyPathDescriptions = 0;

		private static uint __DebugPropertyDescriptions = 0;

		private static uint __DebugPropertyPathDescriptions = 0;

		private static uint __ExternalPropertyDescriptions = 0;

		private static uint __ExternalPropertyPathDescriptions = 0;

		private static uint __ExternalRegisterIndexToVariable = 0;

		private static uint __Operands = 0;

		private static uint __Hash = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}