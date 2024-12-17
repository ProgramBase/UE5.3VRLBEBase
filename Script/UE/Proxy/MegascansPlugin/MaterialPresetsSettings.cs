using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MegascansPlugin
{
	[PathName("/Script/MegascansPlugin.MaterialPresetsSettings")]
	public partial class UMaterialPresetsSettings : UObject, IStaticClass
	{
		public TLazyObjectPtr<UMaterial> MasterMaterial3d
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MasterMaterial3d, __ReturnBuffer);

					return *(TLazyObjectPtr<UMaterial>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MasterMaterial3d, __InBuffer);
				}
			}
		}

		public TLazyObjectPtr<UMaterial> MasterMaterialSurface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MasterMaterialSurface, __ReturnBuffer);

					return *(TLazyObjectPtr<UMaterial>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MasterMaterialSurface, __InBuffer);
				}
			}
		}

		public TLazyObjectPtr<UMaterial> MasterMaterialPlant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MasterMaterialPlant, __ReturnBuffer);

					return *(TLazyObjectPtr<UMaterial>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MasterMaterialPlant, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MegascansPlugin.MaterialPresetsSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MasterMaterial3d = 0;

		private static uint __MasterMaterialSurface = 0;

		private static uint __MasterMaterialPlant = 0;
	}
}