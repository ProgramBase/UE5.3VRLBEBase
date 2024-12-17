using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LocalHeightFog")]
	public partial class ALocalHeightFog : AInfo, IStaticClass
	{
		public ULocalHeightFogComponent LocalHeightFogVolume
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LocalHeightFogVolume, __ReturnBuffer);

					return *(ULocalHeightFogComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LocalHeightFogVolume, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LocalHeightFog");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LocalHeightFogVolume = 0;
	}
}