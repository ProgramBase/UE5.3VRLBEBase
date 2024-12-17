using Script.CoreUObject;
using Script.Library;

namespace Script.InternationalizationSettings
{
	[PathName("/Script/InternationalizationSettings.InternationalizationSettingsModel")]
	public partial class UInternationalizationSettingsModel : UObject, IStaticClass
	{
		public ETimezoneSetting DisplayTimezone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayTimezone, __ReturnBuffer);

					return *(ETimezoneSetting*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayTimezone, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InternationalizationSettings.InternationalizationSettingsModel");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DisplayTimezone = 0;
	}
}