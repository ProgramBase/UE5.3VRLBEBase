using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangePipelineBase")]
	public partial class UInterchangePipelineBase : UObject, IStaticClass
	{
		public UInterchangeResultsContainer Results
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Results, __ReturnBuffer);

					return *(UInterchangeResultsContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Results, __InBuffer);
				}
			}
		}

		public TMap<FName, FInterchangePipelinePropertyStates> PropertiesStates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PropertiesStates, __ReturnBuffer);

					return *(TMap<FName, FInterchangePipelinePropertyStates>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PropertiesStates, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeCore.InterchangePipelineBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ScriptedSetReimportSourceIndex(UClass ReimportObjectClass, int SourceFileIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ReimportObjectClass?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SourceFileIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScriptedSetReimportSourceIndex, __InBuffer);
			}
		}

		public virtual void ScriptedExecutePreImportPipeline(UInterchangeBaseNodeContainer BaseNodeContainer, TArray<UInterchangeSourceData> SourceDatas)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BaseNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceDatas?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScriptedExecutePreImportPipeline, __InBuffer);
			}
		}

		/// <example>
		/// - PhysicsAsset need skeletal mesh render data to be build properly.
		/// </example>
		/// <note>
		/// - the FTaskPipelinePostImport is calling this function not the virtual one that is call by the default implementation.
		/// </note>
		public virtual void ScriptedExecutePostImportPipeline(UInterchangeBaseNodeContainer BaseNodeContainer, FString FactoryNodeKey, UObject CreatedAsset, bool bIsAReimport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = BaseNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FactoryNodeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = CreatedAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bIsAReimport;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScriptedExecutePostImportPipeline, __InBuffer);
			}
		}

		/// <note>
		/// - the FTaskPreCompletion task is calling this function not the virtual one that is call by the default implementation.
		/// </note>
		public virtual void ScriptedExecutePostFactoryPipeline(UInterchangeBaseNodeContainer BaseNodeContainer, FString FactoryNodeKey, UObject CreatedAsset, bool bIsAReimport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = BaseNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FactoryNodeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = CreatedAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bIsAReimport;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScriptedExecutePostFactoryPipeline, __InBuffer);
			}
		}

		/// <note>
		/// - the FTaskPipeline is calling this function not the virtual one that is call by the default implementation.
		/// </note>
		public virtual void ScriptedExecutePipeline(UInterchangeBaseNodeContainer BaseNodeContainer, TArray<UInterchangeSourceData> SourceDatas)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BaseNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceDatas?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScriptedExecutePipeline, __InBuffer);
			}
		}

		public virtual void ScriptedExecuteExportPipeline(UInterchangeBaseNodeContainer BaseNodeContainer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BaseNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScriptedExecuteExportPipeline, __InBuffer);
			}
		}

		public virtual bool ScriptedCanExecuteOnAnyThread(EInterchangePipelineTask PipelineTask)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)PipelineTask;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ScriptedCanExecuteOnAnyThread, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FInterchangePipelinePropertyStates FindOrAddPropertyStates(FName PropertyPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PropertyPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindOrAddPropertyStates, __InBuffer, __ReturnBuffer);

				return *(FInterchangePipelinePropertyStates*)__ReturnBuffer;
			}
		}

		public virtual bool DoesPropertyStatesExist(FName PropertyPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PropertyPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DoesPropertyStatesExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Results = 0;

		private static uint __PropertiesStates = 0;

		private static uint __ScriptedSetReimportSourceIndex = 0;

		private static uint __ScriptedExecutePreImportPipeline = 0;

		private static uint __ScriptedExecutePostImportPipeline = 0;

		private static uint __ScriptedExecutePostFactoryPipeline = 0;

		private static uint __ScriptedExecutePipeline = 0;

		private static uint __ScriptedExecuteExportPipeline = 0;

		private static uint __ScriptedCanExecuteOnAnyThread = 0;

		private static uint __FindOrAddPropertyStates = 0;

		private static uint __DoesPropertyStatesExist = 0;
	}
}