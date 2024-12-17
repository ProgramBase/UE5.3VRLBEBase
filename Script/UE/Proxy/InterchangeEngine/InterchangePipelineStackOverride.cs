using Script.CoreUObject;
using Script.Library;
using Script.InterchangeCore;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangePipelineStackOverride")]
	public partial class UInterchangePipelineStackOverride : UObject, IStaticClass
	{
		public TArray<FSoftObjectPath> OverridePipelines
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverridePipelines, __ReturnBuffer);

					return *(TArray<FSoftObjectPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverridePipelines, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEngine.InterchangePipelineStackOverride");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void AddPythonPipeline(UInterchangePythonPipelineBase PipelineBase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PipelineBase?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddPythonPipeline, __InBuffer);
			}
		}

		public virtual void AddPipeline(UInterchangePipelineBase PipelineBase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PipelineBase?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddPipeline, __InBuffer);
			}
		}

		public virtual void AddBlueprintPipeline(UInterchangeBlueprintPipelineBase PipelineBase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PipelineBase?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddBlueprintPipeline, __InBuffer);
			}
		}

		private static uint __OverridePipelines = 0;

		private static uint __AddPythonPipeline = 0;

		private static uint __AddPipeline = 0;

		private static uint __AddBlueprintPipeline = 0;
	}
}