using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.SoundfieldEffectBase")]
	public partial class USoundfieldEffectBase : UObject, IStaticClass
	{
		public USoundfieldEffectSettingsBase Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(USoundfieldEffectSettingsBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.SoundfieldEffectBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Settings = 0;
	}
}