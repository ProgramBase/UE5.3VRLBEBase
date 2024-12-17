using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AtmosphericFog")]
	public partial class AAtmosphericFog : AInfo, IStaticClass
	{
		public UAtmosphericFogComponent AtmosphericFogComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AtmosphericFogComponent, __ReturnBuffer);

					return *(UAtmosphericFogComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AtmosphericFogComponent, __InBuffer);
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AtmosphericFog");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AtmosphericFogComponent = 0;

		private static uint __ArrowComponent = 0;
	}
}