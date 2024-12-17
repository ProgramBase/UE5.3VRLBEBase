using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMFunctionLibrary")]
	public partial class URigVMFunctionLibrary : URigVMGraph, IStaticClass
	{
		public TArray<FName> PublicFunctionNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PublicFunctionNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PublicFunctionNames, __InBuffer);
				}
			}
		}

		public TMap<FString, URigVMLibraryNode> LocalizedFunctions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LocalizedFunctions, __ReturnBuffer);

					return *(TMap<FString, URigVMLibraryNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LocalizedFunctions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual TArray<TSoftObjectPtr<URigVMFunctionReferenceNode>> GetReferencesForFunction(FName InFunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFunctionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetReferencesForFunction, __InBuffer, __ReturnBuffer);

				return *(TArray<TSoftObjectPtr<URigVMFunctionReferenceNode>>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FString> GetReferencePathsForFunction(FName InFunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFunctionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetReferencePathsForFunction, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMLibraryNode> GetFunctions()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFunctions, __ReturnBuffer);

				return *(TArray<URigVMLibraryNode>*)__ReturnBuffer;
			}
		}

		public virtual URigVMLibraryNode FindFunctionForNode(URigVMNode InNode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindFunctionForNode, __InBuffer, __ReturnBuffer);

				return *(URigVMLibraryNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMLibraryNode FindFunction(FName InFunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFunctionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindFunction, __InBuffer, __ReturnBuffer);

				return *(URigVMLibraryNode*)__ReturnBuffer;
			}
		}

		private static uint __PublicFunctionNames = 0;

		private static uint __LocalizedFunctions = 0;

		private static uint __GetReferencesForFunction = 0;

		private static uint __GetReferencePathsForFunction = 0;

		private static uint __GetFunctions = 0;

		private static uint __FindFunctionForNode = 0;

		private static uint __FindFunction = 0;
	}
}