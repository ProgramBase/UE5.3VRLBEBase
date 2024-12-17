using Script.CoreUObject;
using Script.ModelingComponents;
using Script.MeshModelingToolsExp;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.SimplifyMeshTool")]
	public partial class USimplifyMeshTool : USingleSelectionMeshEditingTool, IStaticClass
	{
		public USimplifyMeshToolProperties SimplifyProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SimplifyProperties, __ReturnBuffer);

					return *(USimplifyMeshToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SimplifyProperties, __InBuffer);
				}
			}
		}

		public UMeshStatisticsProperties MeshStatisticsProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshStatisticsProperties, __ReturnBuffer);

					return *(UMeshStatisticsProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshStatisticsProperties, __InBuffer);
				}
			}
		}

		public UMeshOpPreviewWithBackgroundCompute Preview
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Preview, __ReturnBuffer);

					return *(UMeshOpPreviewWithBackgroundCompute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Preview, __InBuffer);
				}
			}
		}

		public UMeshElementsVisualizer MeshElementsDisplay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshElementsDisplay, __ReturnBuffer);

					return *(UMeshElementsVisualizer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshElementsDisplay, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.SimplifyMeshTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SimplifyProperties = 0;

		private static uint __MeshStatisticsProperties = 0;

		private static uint __Preview = 0;

		private static uint __MeshElementsDisplay = 0;
	}
}