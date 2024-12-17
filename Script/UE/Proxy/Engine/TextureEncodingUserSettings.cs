using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TextureEncodingUserSettings")]
	public partial class UTextureEncodingUserSettings : UDeveloperSettings, IStaticClass
	{
		public ETextureEncodeSpeedOverride ForceEncodeSpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForceEncodeSpeed, __ReturnBuffer);

					return *(ETextureEncodeSpeedOverride*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForceEncodeSpeed, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TextureEncodingUserSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ForceEncodeSpeed = 0;
	}
}