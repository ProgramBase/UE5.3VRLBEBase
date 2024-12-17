using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.FOscillator")]
	public partial class FFOscillator : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayCameras.FOscillator");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFOscillator() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFOscillator() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFOscillator A, FFOscillator B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFOscillator A, FFOscillator B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFOscillator;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Amplitude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Amplitude, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Amplitude, __InBuffer);
				}
			}
		}

		public float Frequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Frequency, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Frequency, __InBuffer);
				}
			}
		}

		public EInitialOscillatorOffset InitialOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InitialOffset, __ReturnBuffer);

					return *(EInitialOscillatorOffset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InitialOffset, __InBuffer);
				}
			}
		}

		public EOscillatorWaveform Waveform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Waveform, __ReturnBuffer);

					return *(EOscillatorWaveform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Waveform, __InBuffer);
				}
			}
		}

		private static uint __Amplitude = 0;

		private static uint __Frequency = 0;

		private static uint __InitialOffset = 0;

		private static uint __Waveform = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}