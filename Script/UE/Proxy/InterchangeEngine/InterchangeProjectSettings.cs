using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;
using Script.InterchangeCore;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangeProjectSettings")]
	public partial class UInterchangeProjectSettings : UDeveloperSettings, IStaticClass
	{
		public FInterchangeContentImportSettings ContentImportSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ContentImportSettings, __ReturnBuffer);

					return *(FInterchangeContentImportSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ContentImportSettings, __InBuffer);
				}
			}
		}

		public FInterchangeImportSettings SceneImportSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SceneImportSettings, __ReturnBuffer);

					return *(FInterchangeImportSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SceneImportSettings, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UInterchangeFilePickerBase> FilePickerClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FilePickerClass, __ReturnBuffer);

					return *(TSoftClassPtr<UInterchangeFilePickerBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FilePickerClass, __InBuffer);
				}
			}
		}

		public bool bStaticMeshUseSmoothEdgesIfSmoothingInformationIsMissing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStaticMeshUseSmoothEdgesIfSmoothingInformationIsMissing, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStaticMeshUseSmoothEdgesIfSmoothingInformationIsMissing, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UInterchangePipelineBase> GenericPipelineClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GenericPipelineClass, __ReturnBuffer);

					return *(TSoftClassPtr<UInterchangePipelineBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GenericPipelineClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEngine.InterchangeProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ContentImportSettings = 0;

		private static uint __SceneImportSettings = 0;

		private static uint __FilePickerClass = 0;

		private static uint __bStaticMeshUseSmoothEdgesIfSmoothingInformationIsMissing = 0;

		private static uint __GenericPipelineClass = 0;
	}
}