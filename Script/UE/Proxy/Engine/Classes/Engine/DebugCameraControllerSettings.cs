using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DebugCameraControllerSettings")]
	public partial class UDebugCameraControllerSettings : UDeveloperSettings, IStaticClass
	{
		public TArray<FDebugCameraControllerSettingsViewModeIndex> CycleViewModes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CycleViewModes, __ReturnBuffer);

					return *(TArray<FDebugCameraControllerSettingsViewModeIndex>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CycleViewModes, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DebugCameraControllerSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CycleViewModes = 0;
	}
}