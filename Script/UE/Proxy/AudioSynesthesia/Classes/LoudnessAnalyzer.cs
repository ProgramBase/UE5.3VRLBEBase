using Script.CoreUObject;
using Script.AudioAnalyzer;
using Script.Library;

namespace Script.AudioSynesthesia
{
	[PathName("/Script/AudioSynesthesia.LoudnessAnalyzer")]
	public partial class ULoudnessAnalyzer : UAudioAnalyzer, IStaticClass
	{
		public ULoudnessSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(ULoudnessSettings*)__ReturnBuffer;
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

		public FOnOverallLoudnessResults OnOverallLoudnessResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnOverallLoudnessResults, __ReturnBuffer);

					return *(FOnOverallLoudnessResults*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnOverallLoudnessResults, __InBuffer);
				}
			}
		}

		public FOnPerChannelLoudnessResults OnPerChannelLoudnessResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPerChannelLoudnessResults, __ReturnBuffer);

					return *(FOnPerChannelLoudnessResults*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPerChannelLoudnessResults, __InBuffer);
				}
			}
		}

		public FOnLatestOverallLoudnessResults OnLatestOverallLoudnessResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnLatestOverallLoudnessResults, __ReturnBuffer);

					return *(FOnLatestOverallLoudnessResults*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnLatestOverallLoudnessResults, __InBuffer);
				}
			}
		}

		public FOnLatestPerChannelLoudnessResults OnLatestPerChannelLoudnessResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnLatestPerChannelLoudnessResults, __ReturnBuffer);

					return *(FOnLatestPerChannelLoudnessResults*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnLatestPerChannelLoudnessResults, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioSynesthesia.LoudnessAnalyzer");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Settings = 0;

		private static uint __OnOverallLoudnessResults = 0;

		private static uint __OnPerChannelLoudnessResults = 0;

		private static uint __OnLatestOverallLoudnessResults = 0;

		private static uint __OnLatestPerChannelLoudnessResults = 0;
	}
}