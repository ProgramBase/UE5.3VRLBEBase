using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.MeshModelingTools;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.AddPatchTool")]
	public partial class UAddPatchTool : USingleClickTool, IStaticClass
	{
		public UAddPatchToolProperties ShapeSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeSettings, __ReturnBuffer);

					return *(UAddPatchToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeSettings, __InBuffer);
				}
			}
		}

		public UNewMeshMaterialProperties MaterialProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialProperties, __ReturnBuffer);

					return *(UNewMeshMaterialProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialProperties, __InBuffer);
				}
			}
		}

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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.AddPatchTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ShapeSettings = 0;

		private static uint __MaterialProperties = 0;

		private static uint __PreviewMesh = 0;
	}
}