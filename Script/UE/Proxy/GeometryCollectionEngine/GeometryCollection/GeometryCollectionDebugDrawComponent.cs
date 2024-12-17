using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawComponent")]
	public partial class UGeometryCollectionDebugDrawComponent : UActorComponent, IStaticClass
	{
		public AGeometryCollectionRenderLevelSetActor GeometryCollectionRenderLevelSetActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryCollectionRenderLevelSetActor, __ReturnBuffer);

					return *(AGeometryCollectionRenderLevelSetActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryCollectionRenderLevelSetActor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GeometryCollectionRenderLevelSetActor = 0;
	}
}