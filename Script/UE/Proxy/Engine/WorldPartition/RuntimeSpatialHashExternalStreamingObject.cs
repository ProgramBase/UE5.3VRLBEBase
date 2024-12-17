using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RuntimeSpatialHashExternalStreamingObject")]
	public partial class URuntimeSpatialHashExternalStreamingObject : URuntimeHashExternalStreamingObjectBase, IStaticClass
	{
		public TArray<FSpatialHashStreamingGrid> StreamingGrids
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingGrids, __ReturnBuffer);

					return *(TArray<FSpatialHashStreamingGrid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingGrids, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RuntimeSpatialHashExternalStreamingObject");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __StreamingGrids = 0;
	}
}