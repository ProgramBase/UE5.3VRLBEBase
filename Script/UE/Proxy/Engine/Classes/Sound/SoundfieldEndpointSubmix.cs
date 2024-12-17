using Script.CoreUObject;
using Script.AudioExtensions;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundfieldEndpointSubmix")]
	public partial class USoundfieldEndpointSubmix : USoundSubmixBase, IStaticClass
	{
		public FName SoundfieldEndpointType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoundfieldEndpointType, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoundfieldEndpointType, __InBuffer);
				}
			}
		}

		public TSubclassOf<UAudioEndpointSettingsBase> EndpointSettingsClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EndpointSettingsClass, __ReturnBuffer);

					return *(TSubclassOf<UAudioEndpointSettingsBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EndpointSettingsClass, __InBuffer);
				}
			}
		}

		public USoundfieldEndpointSettingsBase EndpointSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EndpointSettings, __ReturnBuffer);

					return *(USoundfieldEndpointSettingsBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EndpointSettings, __InBuffer);
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundfieldEndpointSubmix");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SoundfieldEndpointType = 0;

		private static uint __EndpointSettingsClass = 0;

		private static uint __EndpointSettings = 0;

		private static uint __EncodingSettingsClass = 0;

		private static uint __EncodingSettings = 0;

		private static uint __SoundfieldEffectChain = 0;
	}
}