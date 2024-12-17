using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.HeterogeneousVolume")]
	public partial class AHeterogeneousVolume : AInfo, IStaticClass
	{
		public UHeterogeneousVolumeComponent HeterogeneousVolumeComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HeterogeneousVolumeComponent, __ReturnBuffer);

					return *(UHeterogeneousVolumeComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HeterogeneousVolumeComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.HeterogeneousVolume");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __HeterogeneousVolumeComponent = 0;
	}
}