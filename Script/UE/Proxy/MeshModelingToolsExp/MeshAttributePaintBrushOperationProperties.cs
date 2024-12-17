using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MeshAttributePaintBrushOperationProperties")]
	public partial class UMeshAttributePaintBrushOperationProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public EBrushActionMode BrushAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrushAction, __ReturnBuffer);

					return *(EBrushActionMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrushAction, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MeshAttributePaintBrushOperationProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BrushAction = 0;
	}
}