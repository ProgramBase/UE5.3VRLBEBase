using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkyAtmosphere")]
	public partial class ASkyAtmosphere : AInfo, IStaticClass
	{
		public USkyAtmosphereComponent SkyAtmosphereComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkyAtmosphereComponent, __ReturnBuffer);

					return *(USkyAtmosphereComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkyAtmosphereComponent, __InBuffer);
				}
			}
		}

		public UArrowComponent ArrowComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ArrowComponent, __ReturnBuffer);

					return *(UArrowComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ArrowComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SkyAtmosphere");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SkyAtmosphereComponent = 0;

		private static uint __ArrowComponent = 0;
	}
}