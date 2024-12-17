using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.GLTFMaterialExportOptions")]
	public partial class UGLTFMaterialExportOptions : UAssetUserData, IStaticClass
	{
		public UMaterialInterface Proxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Proxy, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Proxy, __InBuffer);
				}
			}
		}

		public FGLTFOverrideMaterialBakeSettings Default
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Default, __ReturnBuffer);

					return *(FGLTFOverrideMaterialBakeSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Default, __InBuffer);
				}
			}
		}

		public TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings> Inputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Inputs, __ReturnBuffer);

					return *(TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Inputs, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GLTFExporter.GLTFMaterialExportOptions");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Proxy = 0;

		private static uint __Default = 0;

		private static uint __Inputs = 0;
	}
}