using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.GeometryCacheActor")]
	public partial class AGeometryCacheActor : AActor, IStaticClass
	{
		public UGeometryCacheComponent GeometryCacheComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryCacheComponent, __ReturnBuffer);

					return *(UGeometryCacheComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryCacheComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCache.GeometryCacheActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UGeometryCacheComponent GetGeometryCacheComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGeometryCacheComponent, __ReturnBuffer);

				return *(UGeometryCacheComponent*)__ReturnBuffer;
			}
		}

		private static uint __GeometryCacheComponent = 0;

		private static uint __GetGeometryCacheComponent = 0;
	}
}