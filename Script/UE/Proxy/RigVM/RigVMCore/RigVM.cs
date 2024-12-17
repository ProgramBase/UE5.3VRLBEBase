using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVM")]
	public partial class URigVM : UObject, IStaticClass
	{
		public URigVMMemoryStorage WorkMemoryStorageObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WorkMemoryStorageObject, __ReturnBuffer);

					return *(URigVMMemoryStorage*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WorkMemoryStorageObject, __InBuffer);
				}
			}
		}

		public URigVMMemoryStorage LiteralMemoryStorageObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LiteralMemoryStorageObject, __ReturnBuffer);

					return *(URigVMMemoryStorage*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LiteralMemoryStorageObject, __InBuffer);
				}
			}
		}

		public URigVMMemoryStorage DebugMemoryStorageObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugMemoryStorageObject, __ReturnBuffer);

					return *(URigVMMemoryStorage*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugMemoryStorageObject, __InBuffer);
				}
			}
		}

		public FRigVMByteCode ByteCodeStorage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ByteCodeStorage, __ReturnBuffer);

					return *(FRigVMByteCode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ByteCodeStorage, __InBuffer);
				}
			}
		}

		public FRigVMInstructionArray Instructions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Instructions, __ReturnBuffer);

					return *(FRigVMInstructionArray*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Instructions, __InBuffer);
				}
			}
		}

		public TArray<FName> FunctionNamesStorage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FunctionNamesStorage, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FunctionNamesStorage, __InBuffer);
				}
			}
		}

		public TArray<FRigVMParameter> Parameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Parameters, __ReturnBuffer);

					return *(TArray<FRigVMParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Parameters, __InBuffer);
				}
			}
		}

		public TMap<FName, int> ParametersNameMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParametersNameMap, __ReturnBuffer);

					return *(TMap<FName, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParametersNameMap, __InBuffer);
				}
			}
		}

		public URigVM DeferredVMToCopy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeferredVMToCopy, __ReturnBuffer);

					return *(URigVM*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DeferredVMToCopy, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVM.RigVM");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetParameterValueVector2D(FName InParameterName, FVector2D InValue, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = InArrayIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParameterValueVector2D, __InBuffer);
			}
		}

		public virtual void SetParameterValueVector(FName InParameterName, FVector InValue, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = InArrayIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParameterValueVector, __InBuffer);
			}
		}

		public virtual void SetParameterValueTransform(FName InParameterName, FTransform InValue, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = InArrayIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParameterValueTransform, __InBuffer);
			}
		}

		public virtual void SetParameterValueString(FName InParameterName, FString InValue, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = InArrayIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParameterValueString, __InBuffer);
			}
		}

		public virtual void SetParameterValueQuat(FName InParameterName, FQuat InValue, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = InArrayIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParameterValueQuat, __InBuffer);
			}
		}

		public virtual void SetParameterValueName(FName InParameterName, FName InValue, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = InArrayIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParameterValueName, __InBuffer);
			}
		}

		public virtual void SetParameterValueInt(FName InParameterName, int InValue, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InValue;

				*(int*)(__InBuffer + 12) = InArrayIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParameterValueInt, __InBuffer);
			}
		}

		public virtual void SetParameterValueFloat(FName InParameterName, float InValue, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InValue;

				*(int*)(__InBuffer + 12) = InArrayIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParameterValueFloat, __InBuffer);
			}
		}

		public virtual void SetParameterValueDouble(FName InParameterName, double InValue, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = InValue;

				*(int*)(__InBuffer + 16) = InArrayIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParameterValueDouble, __InBuffer);
			}
		}

		public virtual void SetParameterValueBool(FName InParameterName, bool InValue, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = InValue;

				*(int*)(__InBuffer + 9) = InArrayIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParameterValueBool, __InBuffer);
			}
		}

		public virtual FRigVMStatistics GetStatistics()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetStatistics, __ReturnBuffer);

				return *(FRigVMStatistics*)__ReturnBuffer;
			}
		}

		public virtual FString GetRigVMFunctionName(int InFunctionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFunctionIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRigVMFunctionName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetParameterValueVector2D(FName InParameterName, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InArrayIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParameterValueVector2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual FVector GetParameterValueVector(FName InParameterName, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InArrayIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParameterValueVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetParameterValueTransform(FName InParameterName, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InArrayIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParameterValueTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual FString GetParameterValueString(FName InParameterName, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InArrayIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParameterValueString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FQuat GetParameterValueQuat(FName InParameterName, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InArrayIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParameterValueQuat, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public virtual FName GetParameterValueName(FName InParameterName, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InArrayIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParameterValueName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual int GetParameterValueInt(FName InParameterName, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InArrayIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetParameterValueInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual float GetParameterValueFloat(FName InParameterName, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InArrayIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetParameterValueFloat, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual double GetParameterValueDouble(FName InParameterName, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InArrayIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetParameterValueDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public virtual bool GetParameterValueBool(FName InParameterName, int InArrayIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InArrayIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetParameterValueBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool Execute(ref FRigVMExtendedExecuteContext Context, FName InEntryName = null)
		{
			unsafe
			{
				InEntryName ??= new FName("None");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InEntryName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __Execute, __InBuffer, __OutBuffer, __ReturnBuffer);

				Context = *(FRigVMExtendedExecuteContext*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual int AddRigVMFunction(UScriptStruct InRigVMStruct, FName InMethodName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InRigVMStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMethodName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddRigVMFunction, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __WorkMemoryStorageObject = 0;

		private static uint __LiteralMemoryStorageObject = 0;

		private static uint __DebugMemoryStorageObject = 0;

		private static uint __ByteCodeStorage = 0;

		private static uint __Instructions = 0;

		private static uint __FunctionNamesStorage = 0;

		private static uint __Parameters = 0;

		private static uint __ParametersNameMap = 0;

		private static uint __DeferredVMToCopy = 0;

		private static uint __SetParameterValueVector2D = 0;

		private static uint __SetParameterValueVector = 0;

		private static uint __SetParameterValueTransform = 0;

		private static uint __SetParameterValueString = 0;

		private static uint __SetParameterValueQuat = 0;

		private static uint __SetParameterValueName = 0;

		private static uint __SetParameterValueInt = 0;

		private static uint __SetParameterValueFloat = 0;

		private static uint __SetParameterValueDouble = 0;

		private static uint __SetParameterValueBool = 0;

		private static uint __GetStatistics = 0;

		private static uint __GetRigVMFunctionName = 0;

		private static uint __GetParameterValueVector2D = 0;

		private static uint __GetParameterValueVector = 0;

		private static uint __GetParameterValueTransform = 0;

		private static uint __GetParameterValueString = 0;

		private static uint __GetParameterValueQuat = 0;

		private static uint __GetParameterValueName = 0;

		private static uint __GetParameterValueInt = 0;

		private static uint __GetParameterValueFloat = 0;

		private static uint __GetParameterValueDouble = 0;

		private static uint __GetParameterValueBool = 0;

		private static uint __Execute = 0;

		private static uint __AddRigVMFunction = 0;
	}
}