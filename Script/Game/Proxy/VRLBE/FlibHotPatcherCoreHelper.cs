using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.FlibHotPatcherCoreHelper")]
	public partial class UFlibHotPatcherCoreHelper : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.FlibHotPatcherCoreHelper");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FString GetUnrealPakBinary()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetUnrealPakBinary, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetUECmdBinary()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetUECmdBinary, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetAllCookOption()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAllCookOption, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		private static uint __GetUnrealPakBinary = 0;

		private static uint __GetUECmdBinary = 0;

		private static uint __GetAllCookOption = 0;
	}
}