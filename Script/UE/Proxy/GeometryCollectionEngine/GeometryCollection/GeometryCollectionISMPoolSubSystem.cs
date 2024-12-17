using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionISMPoolSubSystem")]
	public partial class UGeometryCollectionISMPoolSubSystem : UWorldSubsystem, IStaticClass
	{
		public AGeometryCollectionISMPoolActor ISMPoolActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ISMPoolActor, __ReturnBuffer);

					return *(AGeometryCollectionISMPoolActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ISMPoolActor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionEngine.GeometryCollectionISMPoolSubSystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ISMPoolActor = 0;
	}
}