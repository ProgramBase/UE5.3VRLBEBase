using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.GeometryCacheTrackStreamable")]
	public partial class UGeometryCacheTrackStreamable : UGeometryCacheTrack, IStaticClass
	{
		public UGeometryCacheCodecBase Codec
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Codec, __ReturnBuffer);

					return *(UGeometryCacheCodecBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Codec, __InBuffer);
				}
			}
		}

		public float StartSampleTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartSampleTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartSampleTime, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCache.GeometryCacheTrackStreamable");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Codec = 0;

		private static uint __StartSampleTime = 0;
	}
}