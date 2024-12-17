using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundWaveSpectralDataPerSound")]
	public partial class FSoundWaveSpectralDataPerSound : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SoundWaveSpectralDataPerSound");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundWaveSpectralDataPerSound() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSoundWaveSpectralDataPerSound() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSoundWaveSpectralDataPerSound A, FSoundWaveSpectralDataPerSound B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundWaveSpectralDataPerSound A, FSoundWaveSpectralDataPerSound B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundWaveSpectralDataPerSound;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FSoundWaveSpectralData> SpectralData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpectralData, __ReturnBuffer);

					return *(TArray<FSoundWaveSpectralData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpectralData, __InBuffer);
				}
			}
		}

		public float PlaybackTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlaybackTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlaybackTime, __InBuffer);
				}
			}
		}

		public USoundWave SoundWave
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SoundWave, __ReturnBuffer);

					return *(USoundWave*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SoundWave, __InBuffer);
				}
			}
		}

		private static uint __SpectralData = 0;

		private static uint __PlaybackTime = 0;

		private static uint __SoundWave = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}