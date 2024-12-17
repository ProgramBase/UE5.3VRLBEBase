using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.BakeRenderCaptureToolProperties")]
	public partial class UBakeRenderCaptureToolProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public FString MapPreview
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MapPreview, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MapPreview, __InBuffer);
				}
			}
		}

		public TArray<FString> MapPreviewNamesList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MapPreviewNamesList, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MapPreviewNamesList, __InBuffer);
				}
			}
		}

		public EBakeTextureSamplesPerPixel SamplesPerPixel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SamplesPerPixel, __ReturnBuffer);

					return *(EBakeTextureSamplesPerPixel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SamplesPerPixel, __InBuffer);
				}
			}
		}

		public EBakeTextureResolution TextureSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureSize, __ReturnBuffer);

					return *(EBakeTextureResolution*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureSize, __InBuffer);
				}
			}
		}

		public float ValidSampleDepthThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ValidSampleDepthThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ValidSampleDepthThreshold, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.BakeRenderCaptureToolProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual TArray<FString> GetMapPreviewNamesFunc()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMapPreviewNamesFunc, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		private static uint __MapPreview = 0;

		private static uint __MapPreviewNamesList = 0;

		private static uint __SamplesPerPixel = 0;

		private static uint __TextureSize = 0;

		private static uint __ValidSampleDepthThreshold = 0;

		private static uint __GetMapPreviewNamesFunc = 0;
	}
}