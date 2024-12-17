using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithCineCameraActorTemplate")]
	public partial class UDatasmithCineCameraActorTemplate : UDatasmithObjectTemplate, IStaticClass
	{
		public FDatasmithCameraLookatTrackingSettingsTemplate LookatTrackingSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LookatTrackingSettings, __ReturnBuffer);

					return *(FDatasmithCameraLookatTrackingSettingsTemplate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LookatTrackingSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithCineCameraActorTemplate");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LookatTrackingSettings = 0;
	}
}