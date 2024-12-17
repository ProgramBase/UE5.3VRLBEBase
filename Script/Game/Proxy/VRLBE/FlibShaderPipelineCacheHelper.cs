using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.FlibShaderPipelineCacheHelper")]
	public partial class UFlibShaderPipelineCacheHelper : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherRuntime.FlibShaderPipelineCacheHelper");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool SavePipelineFileCache(EPSOSaveMode Mode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Mode;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SavePipelineFileCache, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool LoadShaderPipelineCache(FString Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadShaderPipelineCache, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsEnabledUsePSO()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsEnabledUsePSO, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsEnabledSaveBoundPSOLog()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsEnabledSaveBoundPSOLog, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsEnabledLogPSO()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsEnabledLogPSO, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EnableShaderPipelineCache(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EnableShaderPipelineCache, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EnableSaveBoundPSOLog(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EnableSaveBoundPSOLog, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EnableLogPSO(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EnableLogPSO, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SavePipelineFileCache = 0;

		private static uint __LoadShaderPipelineCache = 0;

		private static uint __IsEnabledUsePSO = 0;

		private static uint __IsEnabledSaveBoundPSOLog = 0;

		private static uint __IsEnabledLogPSO = 0;

		private static uint __EnableShaderPipelineCache = 0;

		private static uint __EnableSaveBoundPSOLog = 0;

		private static uint __EnableLogPSO = 0;
	}
}