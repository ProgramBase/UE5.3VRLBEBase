using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionISMPoolActor")]
	public partial class AGeometryCollectionISMPoolActor : AActor, IStaticClass
	{
		public UGeometryCollectionISMPoolComponent ISMPoolComp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ISMPoolComp, __ReturnBuffer);

					return *(UGeometryCollectionISMPoolComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ISMPoolComp, __InBuffer);
				}
			}
		}

		public UGeometryCollectionISMPoolDebugDrawComponent ISMPoolDebugDrawComp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ISMPoolDebugDrawComp, __ReturnBuffer);

					return *(UGeometryCollectionISMPoolDebugDrawComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ISMPoolDebugDrawComp, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionEngine.GeometryCollectionISMPoolActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ISMPoolComp = 0;

		private static uint __ISMPoolDebugDrawComp = 0;
	}
}