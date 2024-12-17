using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LightmassPrimitiveSettingsObject")]
	public partial class ULightmassPrimitiveSettingsObject : UObject, IStaticClass
	{
		public FLightmassPrimitiveSettings LightmassSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightmassSettings, __ReturnBuffer);

					return *(FLightmassPrimitiveSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightmassSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LightmassPrimitiveSettingsObject");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LightmassSettings = 0;
	}
}