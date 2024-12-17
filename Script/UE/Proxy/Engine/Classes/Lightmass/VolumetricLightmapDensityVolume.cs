using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VolumetricLightmapDensityVolume")]
	public partial class AVolumetricLightmapDensityVolume : AVolume, IStaticClass
	{
		public FInt32Interval AllowedMipLevelRange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AllowedMipLevelRange, __ReturnBuffer);

					return *(FInt32Interval*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AllowedMipLevelRange, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.VolumetricLightmapDensityVolume");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AllowedMipLevelRange = 0;
	}
}