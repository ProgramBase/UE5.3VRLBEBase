using Script.CoreUObject;
using Script.Library;

namespace Script.MaterialShaderQualitySettings
{
	[PathName("/Script/MaterialShaderQualitySettings.ShaderPlatformQualitySettings")]
	public partial class UShaderPlatformQualitySettings : UObject, IStaticClass
	{
		public FMaterialQualityOverrides QualityOverrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __QualityOverrides, __ReturnBuffer);

					return *(FMaterialQualityOverrides*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __QualityOverrides, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MaterialShaderQualitySettings.ShaderPlatformQualitySettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __QualityOverrides = 0;
	}
}