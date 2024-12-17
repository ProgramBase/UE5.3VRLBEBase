using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.SmoothMeshToolProperties")]
	public partial class USmoothMeshToolProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public ESmoothMeshToolSmoothType SmoothingType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SmoothingType, __ReturnBuffer);

					return *(ESmoothMeshToolSmoothType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SmoothingType, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.SmoothMeshToolProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SmoothingType = 0;
	}
}