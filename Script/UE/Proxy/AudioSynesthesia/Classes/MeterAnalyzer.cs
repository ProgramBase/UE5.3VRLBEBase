using Script.CoreUObject;
using Script.AudioAnalyzer;
using Script.Library;

namespace Script.AudioSynesthesia
{
	[PathName("/Script/AudioSynesthesia.MeterAnalyzer")]
	public partial class UMeterAnalyzer : UAudioAnalyzer, IStaticClass
	{
		public UMeterSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(UMeterSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		public FOnOverallMeterResults OnOverallMeterResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnOverallMeterResults, __ReturnBuffer);

					return *(FOnOverallMeterResults*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnOverallMeterResults, __InBuffer);
				}
			}
		}

		public FOnPerChannelMeterResults OnPerChannelMeterResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPerChannelMeterResults, __ReturnBuffer);

					return *(FOnPerChannelMeterResults*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPerChannelMeterResults, __InBuffer);
				}
			}
		}

		public FOnLatestOverallMeterResults OnLatestOverallMeterResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnLatestOverallMeterResults, __ReturnBuffer);

					return *(FOnLatestOverallMeterResults*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnLatestOverallMeterResults, __InBuffer);
				}
			}
		}

		public FOnLatestPerChannelMeterResults OnLatestPerChannelMeterResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnLatestPerChannelMeterResults, __ReturnBuffer);

					return *(FOnLatestPerChannelMeterResults*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnLatestPerChannelMeterResults, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioSynesthesia.MeterAnalyzer");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Settings = 0;

		private static uint __OnOverallMeterResults = 0;

		private static uint __OnPerChannelMeterResults = 0;

		private static uint __OnLatestOverallMeterResults = 0;

		private static uint __OnLatestPerChannelMeterResults = 0;
	}
}