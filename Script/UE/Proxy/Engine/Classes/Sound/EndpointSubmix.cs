using Script.CoreUObject;
using Script.Library;
using Script.AudioExtensions;

namespace Script.Engine
{
	[PathName("/Script/Engine.EndpointSubmix")]
	public partial class UEndpointSubmix : USoundSubmixBase, IStaticClass
	{
		public FName EndpointType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EndpointType, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EndpointType, __InBuffer);
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

		public UAudioEndpointSettingsBase EndpointSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EndpointSettings, __ReturnBuffer);

					return *(UAudioEndpointSettingsBase*)__ReturnBuffer;
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.EndpointSubmix");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EndpointType = 0;

		private static uint __EndpointSettingsClass = 0;

		private static uint __EndpointSettings = 0;
	}
}