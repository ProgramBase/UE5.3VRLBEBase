using Script.CoreUObject;
using Script.Engine;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangeAssetImportData")]
	public partial class UInterchangeAssetImportData : UAssetImportData, IStaticClass
	{
		public FSoftObjectPath SceneImportAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SceneImportAsset, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SceneImportAsset, __InBuffer);
				}
			}
		}

		public FString NodeUniqueID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NodeUniqueID, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NodeUniqueID, __InBuffer);
				}
			}
		}

		public UInterchangeBaseNodeContainer TransientNodeContainer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransientNodeContainer, __ReturnBuffer);

					return *(UInterchangeBaseNodeContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransientNodeContainer, __InBuffer);
				}
			}
		}

		public TArray<UObject> TransientPipelines
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransientPipelines, __ReturnBuffer);

					return *(TArray<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransientPipelines, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEngine.InterchangeAssetImportData");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetPipelines(TArray<UObject> InPipelines)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPipelines?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPipelines, __InBuffer);
			}
		}

		public virtual void SetNodeContainer(UInterchangeBaseNodeContainer InNodeContainer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNodeContainer, __InBuffer);
			}
		}

		public virtual FString ScriptGetFirstFilename()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __ScriptGetFirstFilename, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual TArray<FString> ScriptExtractFilenames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __ScriptExtractFilenames, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FString> ScriptExtractDisplayLabels()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __ScriptExtractDisplayLabels, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public virtual UInterchangeBaseNode GetStoredNode(FString InNodeUniqueId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNodeUniqueId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetStoredNode, __InBuffer, __ReturnBuffer);

				return *(UInterchangeBaseNode*)__ReturnBuffer;
			}
		}

		public virtual UInterchangeFactoryBaseNode GetStoredFactoryNode(FString InNodeUniqueId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNodeUniqueId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetStoredFactoryNode, __InBuffer, __ReturnBuffer);

				return *(UInterchangeFactoryBaseNode*)__ReturnBuffer;
			}
		}

		public virtual TArray<UObject> GetPipelines()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPipelines, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		public virtual int GetNumberOfPipelines()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumberOfPipelines, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual UInterchangeBaseNodeContainer GetNodeContainer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNodeContainer, __ReturnBuffer);

				return *(UInterchangeBaseNodeContainer*)__ReturnBuffer;
			}
		}

		private static uint __SceneImportAsset = 0;

		private static uint __NodeUniqueID = 0;

		private static uint __TransientNodeContainer = 0;

		private static uint __TransientPipelines = 0;

		private static uint __SetPipelines = 0;

		private static uint __SetNodeContainer = 0;

		private static uint __ScriptGetFirstFilename = 0;

		private static uint __ScriptExtractFilenames = 0;

		private static uint __ScriptExtractDisplayLabels = 0;

		private static uint __GetStoredNode = 0;

		private static uint __GetStoredFactoryNode = 0;

		private static uint __GetPipelines = 0;

		private static uint __GetNumberOfPipelines = 0;

		private static uint __GetNodeContainer = 0;
	}
}