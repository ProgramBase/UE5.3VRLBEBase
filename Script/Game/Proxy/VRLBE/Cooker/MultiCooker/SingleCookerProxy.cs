using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.SingleCookerProxy")]
	public partial class USingleCookerProxy : UHotPatcherProxyBase, IStaticClass
	{
		public FCookerPreCacheDDC CookerPreCacheDDC
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CookerPreCacheDDC, __ReturnBuffer);

					return *(FCookerPreCacheDDC*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CookerPreCacheDDC, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.SingleCookerProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CookerPreCacheDDC = 0;
	}
}