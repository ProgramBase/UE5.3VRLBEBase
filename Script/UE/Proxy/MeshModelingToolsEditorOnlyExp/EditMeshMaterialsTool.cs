using Script.CoreUObject;
using Script.MeshModelingToolsExp;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EditMeshMaterialsTool")]
	public partial class UEditMeshMaterialsTool : UMeshSelectionTool, IStaticClass
	{
		public UEditMeshMaterialsToolProperties MaterialProps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialProps, __ReturnBuffer);

					return *(UEditMeshMaterialsToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialProps, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.EditMeshMaterialsTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MaterialProps = 0;
	}
}