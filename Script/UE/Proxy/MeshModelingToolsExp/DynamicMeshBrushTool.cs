using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.DynamicMeshBrushTool")]
	public partial class UDynamicMeshBrushTool : UBaseBrushTool, IStaticClass
	{
		public UPreviewMesh PreviewMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMesh, __ReturnBuffer);

					return *(UPreviewMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMesh, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.DynamicMeshBrushTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PreviewMesh = 0;
	}
}