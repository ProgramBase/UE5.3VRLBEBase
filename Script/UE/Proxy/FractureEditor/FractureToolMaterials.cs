using Script.CoreUObject;
using Script.GeometryCollectionEngine;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolMaterials")]
	public partial class UFractureToolMaterials : UFractureModalTool, IStaticClass
	{
		public UFractureMaterialsSettings MaterialsSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialsSettings, __ReturnBuffer);

					return *(UFractureMaterialsSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialsSettings, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UGeometryCollectionComponent> ActiveSelectedComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveSelectedComponent, __ReturnBuffer);

					return *(TWeakObjectPtr<UGeometryCollectionComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveSelectedComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolMaterials");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MaterialsSettings = 0;

		private static uint __ActiveSelectedComponent = 0;
	}
}