using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SpatialHashRuntimeGridInfo")]
	public partial class ASpatialHashRuntimeGridInfo : AInfo, IStaticClass
	{
		public FSpatialHashRuntimeGrid GridSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GridSettings, __ReturnBuffer);

					return *(FSpatialHashRuntimeGrid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GridSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SpatialHashRuntimeGridInfo");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GridSettings = 0;
	}
}