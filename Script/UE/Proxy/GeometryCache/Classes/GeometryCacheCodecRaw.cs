using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.GeometryCacheCodecRaw")]
	public partial class UGeometryCacheCodecRaw : UGeometryCacheCodecBase, IStaticClass
	{
		public int DummyProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DummyProperty, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DummyProperty, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCache.GeometryCacheCodecRaw");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DummyProperty = 0;
	}
}