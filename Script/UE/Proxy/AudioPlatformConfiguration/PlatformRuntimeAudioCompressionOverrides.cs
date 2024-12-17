using Script.CoreUObject;
using Script.Library;

namespace Script.AudioPlatformConfiguration
{
	[PathName("/Script/AudioPlatformConfiguration.PlatformRuntimeAudioCompressionOverrides")]
	public partial class FPlatformRuntimeAudioCompressionOverrides : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioPlatformConfiguration.PlatformRuntimeAudioCompressionOverrides");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlatformRuntimeAudioCompressionOverrides() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlatformRuntimeAudioCompressionOverrides() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlatformRuntimeAudioCompressionOverrides A, FPlatformRuntimeAudioCompressionOverrides B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlatformRuntimeAudioCompressionOverrides A, FPlatformRuntimeAudioCompressionOverrides B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlatformRuntimeAudioCompressionOverrides;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bOverrideCompressionTimes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideCompressionTimes, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideCompressionTimes, __InBuffer);
				}
			}
		}

		public float DurationThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DurationThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DurationThreshold, __InBuffer);
				}
			}
		}

		public int MaxNumRandomBranches
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxNumRandomBranches, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxNumRandomBranches, __InBuffer);
				}
			}
		}

		public int SoundCueQualityIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SoundCueQualityIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SoundCueQualityIndex, __InBuffer);
				}
			}
		}

		private static uint __bOverrideCompressionTimes = 0;

		private static uint __DurationThreshold = 0;

		private static uint __MaxNumRandomBranches = 0;

		private static uint __SoundCueQualityIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}