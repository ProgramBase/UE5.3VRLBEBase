using Script.CoreUObject;
using Script.Library;

namespace Script.MaterialShaderQualitySettings
{
	[PathName("/Script/MaterialShaderQualitySettings.MaterialShaderQualitySettings")]
	public partial class UMaterialShaderQualitySettings : UObject, IStaticClass
	{
		public TMap<FName, UShaderPlatformQualitySettings> ForwardSettingMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForwardSettingMap, __ReturnBuffer);

					return *(TMap<FName, UShaderPlatformQualitySettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForwardSettingMap, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MaterialShaderQualitySettings.MaterialShaderQualitySettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ForwardSettingMap = 0;
	}
}