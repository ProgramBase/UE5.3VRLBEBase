using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.GeometryCacheCodecBase")]
	public partial class UGeometryCacheCodecBase : UObject, IStaticClass
	{
		public TArray<int> TopologyRanges
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TopologyRanges, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TopologyRanges, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCache.GeometryCacheCodecBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TopologyRanges = 0;
	}
}