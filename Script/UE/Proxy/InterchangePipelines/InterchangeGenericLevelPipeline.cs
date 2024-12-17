using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.InterchangeGenericLevelPipeline")]
	public partial class UInterchangeGenericLevelPipeline : UInterchangePipelineBase, IStaticClass
	{
		public EReimportStrategyFlags ReimportPropertyStrategy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReimportPropertyStrategy, __ReturnBuffer);

					return *(EReimportStrategyFlags*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReimportPropertyStrategy, __InBuffer);
				}
			}
		}

		public bool bDeleteMissingActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDeleteMissingActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDeleteMissingActors, __InBuffer);
				}
			}
		}

		public bool bForceReimportDeletedActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceReimportDeletedActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceReimportDeletedActors, __InBuffer);
				}
			}
		}

		public bool bForceReimportDeletedAssets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceReimportDeletedAssets, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceReimportDeletedAssets, __InBuffer);
				}
			}
		}

		public bool bDeleteMissingAssets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDeleteMissingAssets, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDeleteMissingAssets, __InBuffer);
				}
			}
		}

		public bool bUsePhysicalInsteadOfStandardPerspectiveCamera
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUsePhysicalInsteadOfStandardPerspectiveCamera, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUsePhysicalInsteadOfStandardPerspectiveCamera, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangePipelines.InterchangeGenericLevelPipeline");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ReimportPropertyStrategy = 0;

		private static uint __bDeleteMissingActors = 0;

		private static uint __bForceReimportDeletedActors = 0;

		private static uint __bForceReimportDeletedAssets = 0;

		private static uint __bDeleteMissingAssets = 0;

		private static uint __bUsePhysicalInsteadOfStandardPerspectiveCamera = 0;
	}
}