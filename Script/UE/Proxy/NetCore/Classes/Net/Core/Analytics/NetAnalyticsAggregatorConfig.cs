using Script.CoreUObject;
using Script.Library;

namespace Script.NetCore
{
	[PathName("/Script/NetCore.NetAnalyticsAggregatorConfig")]
	public partial class UNetAnalyticsAggregatorConfig : UObject, IStaticClass
	{
		public TArray<FNetAnalyticsDataConfig> NetAnalyticsData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetAnalyticsData, __ReturnBuffer);

					return *(TArray<FNetAnalyticsDataConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetAnalyticsData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NetCore.NetAnalyticsAggregatorConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NetAnalyticsData = 0;
	}
}