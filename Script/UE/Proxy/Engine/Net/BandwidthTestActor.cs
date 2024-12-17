using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BandwidthTestActor")]
	public partial class ABandwidthTestActor : AActor, IStaticClass
	{
		public FBandwidthTestGenerator BandwidthGenerator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BandwidthGenerator, __ReturnBuffer);

					return *(FBandwidthTestGenerator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BandwidthGenerator, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BandwidthTestActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BandwidthGenerator = 0;
	}
}