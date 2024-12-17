using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionActor")]
	public partial class AGeometryCollectionActor : AActor, IStaticClass
	{
		public UGeometryCollectionComponent GeometryCollectionComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryCollectionComponent, __ReturnBuffer);

					return *(UGeometryCollectionComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryCollectionComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionEngine.GeometryCollectionActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool RaycastSingle(FVector Start, FVector End, ref FHitResult OutHit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __RaycastSingle, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __GeometryCollectionComponent = 0;

		private static uint __RaycastSingle = 0;
	}
}