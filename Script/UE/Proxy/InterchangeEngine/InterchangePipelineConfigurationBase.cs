using Script.CoreUObject;
using Script.Library;
using Script.InterchangeCore;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangePipelineConfigurationBase")]
	public partial class UInterchangePipelineConfigurationBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEngine.InterchangePipelineConfigurationBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual EInterchangePipelineConfigurationDialogResult ScriptedShowScenePipelineConfigurationDialog(ref TArray<FInterchangeStackInfo> PipelineStacks, ref TArray<UInterchangePipelineBase> OutPipelines, UInterchangeSourceData SourceData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PipelineStacks?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPipelines?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SourceData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __ScriptedShowScenePipelineConfigurationDialog, __InBuffer, __OutBuffer, __ReturnBuffer);

				PipelineStacks = *(TArray<FInterchangeStackInfo>*)(__OutBuffer);

				OutPipelines = *(TArray<UInterchangePipelineBase>*)(__OutBuffer + 8);

				return *(EInterchangePipelineConfigurationDialogResult*)__ReturnBuffer;
			}
		}

		public virtual EInterchangePipelineConfigurationDialogResult ScriptedShowReimportPipelineConfigurationDialog(ref TArray<FInterchangeStackInfo> PipelineStacks, ref TArray<UInterchangePipelineBase> OutPipelines, UInterchangeSourceData SourceData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PipelineStacks?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPipelines?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SourceData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __ScriptedShowReimportPipelineConfigurationDialog, __InBuffer, __OutBuffer, __ReturnBuffer);

				PipelineStacks = *(TArray<FInterchangeStackInfo>*)(__OutBuffer);

				OutPipelines = *(TArray<UInterchangePipelineBase>*)(__OutBuffer + 8);

				return *(EInterchangePipelineConfigurationDialogResult*)__ReturnBuffer;
			}
		}

		public virtual EInterchangePipelineConfigurationDialogResult ScriptedShowPipelineConfigurationDialog(ref TArray<FInterchangeStackInfo> PipelineStacks, ref TArray<UInterchangePipelineBase> OutPipelines, UInterchangeSourceData SourceData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PipelineStacks?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPipelines?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SourceData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __ScriptedShowPipelineConfigurationDialog, __InBuffer, __OutBuffer, __ReturnBuffer);

				PipelineStacks = *(TArray<FInterchangeStackInfo>*)(__OutBuffer);

				OutPipelines = *(TArray<UInterchangePipelineBase>*)(__OutBuffer + 8);

				return *(EInterchangePipelineConfigurationDialogResult*)__ReturnBuffer;
			}
		}

		private static uint __ScriptedShowScenePipelineConfigurationDialog = 0;

		private static uint __ScriptedShowReimportPipelineConfigurationDialog = 0;

		private static uint __ScriptedShowPipelineConfigurationDialog = 0;
	}
}