using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.DisplaceMeshPerlinNoiseProperties")]
	public partial class UDisplaceMeshPerlinNoiseProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public TArray<FPerlinLayerProperties> PerlinLayerProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerlinLayerProperties, __ReturnBuffer);

					return *(TArray<FPerlinLayerProperties>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerlinLayerProperties, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.DisplaceMeshPerlinNoiseProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PerlinLayerProperties = 0;
	}
}