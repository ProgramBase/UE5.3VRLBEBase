using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Engine;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.SingleTargetWithSelectionTool")]
	public partial class USingleTargetWithSelectionTool : USingleSelectionTool, IStaticClass
	{
		public TWeakObjectPtr<UWorld> TargetWorld
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetWorld, __ReturnBuffer);

					return *(TWeakObjectPtr<UWorld>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetWorld, __InBuffer);
				}
			}
		}

		public UGeometrySelectionVisualizationProperties GeometrySelectionVizProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeometrySelectionVizProperties, __ReturnBuffer);

					return *(UGeometrySelectionVisualizationProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeometrySelectionVizProperties, __InBuffer);
				}
			}
		}

		public UPreviewGeometry GeometrySelectionViz
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeometrySelectionViz, __ReturnBuffer);

					return *(UPreviewGeometry*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeometrySelectionViz, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.SingleTargetWithSelectionTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TargetWorld = 0;

		private static uint __GeometrySelectionVizProperties = 0;

		private static uint __GeometrySelectionViz = 0;
	}
}