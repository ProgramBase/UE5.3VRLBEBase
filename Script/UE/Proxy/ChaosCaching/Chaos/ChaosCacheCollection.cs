using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.ChaosCacheCollection")]
	public partial class UChaosCacheCollection : UObject, IStaticClass
	{
		public TArray<UChaosCache> Caches
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Caches, __ReturnBuffer);

					return *(TArray<UChaosCache>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Caches, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosCaching.ChaosCacheCollection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Caches = 0;
	}
}