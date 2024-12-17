using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.LocalizationSettings")]
	public partial class ULocalizationSettings : UObject, IStaticClass
	{
		public ULocalizationTargetSet EngineTargetSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EngineTargetSet, __ReturnBuffer);

					return *(ULocalizationTargetSet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EngineTargetSet, __InBuffer);
				}
			}
		}

		public TArray<FLocalizationTargetSettings> EngineTargetsSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EngineTargetsSettings, __ReturnBuffer);

					return *(TArray<FLocalizationTargetSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EngineTargetsSettings, __InBuffer);
				}
			}
		}

		public ULocalizationTargetSet GameTargetSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameTargetSet, __ReturnBuffer);

					return *(ULocalizationTargetSet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameTargetSet, __InBuffer);
				}
			}
		}

		public TArray<FLocalizationTargetSettings> GameTargetsSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameTargetsSettings, __ReturnBuffer);

					return *(TArray<FLocalizationTargetSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameTargetsSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Localization.LocalizationSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EngineTargetSet = 0;

		private static uint __EngineTargetsSettings = 0;

		private static uint __GameTargetSet = 0;

		private static uint __GameTargetsSettings = 0;
	}
}