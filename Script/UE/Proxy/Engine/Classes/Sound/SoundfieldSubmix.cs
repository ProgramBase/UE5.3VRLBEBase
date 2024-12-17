using Script.CoreUObject;
using Script.AudioExtensions;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundfieldSubmix")]
	public partial class USoundfieldSubmix : USoundSubmixWithParentBase, IStaticClass
	{
		public FName SoundfieldEncodingFormat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoundfieldEncodingFormat, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoundfieldEncodingFormat, __InBuffer);
				}
			}
		}

		public USoundfieldEncodingSettingsBase EncodingSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EncodingSettings, __ReturnBuffer);

					return *(USoundfieldEncodingSettingsBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EncodingSettings, __InBuffer);
				}
			}
		}

		public TArray<USoundfieldEffectBase> SoundfieldEffectChain
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoundfieldEffectChain, __ReturnBuffer);

					return *(TArray<USoundfieldEffectBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoundfieldEffectChain, __InBuffer);
				}
			}
		}

		public TSubclassOf<USoundfieldEncodingSettingsBase> EncodingSettingsClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EncodingSettingsClass, __ReturnBuffer);

					return *(TSubclassOf<USoundfieldEncodingSettingsBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EncodingSettingsClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundfieldSubmix");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SoundfieldEncodingFormat = 0;

		private static uint __EncodingSettings = 0;

		private static uint __SoundfieldEffectChain = 0;

		private static uint __EncodingSettingsClass = 0;
	}
}