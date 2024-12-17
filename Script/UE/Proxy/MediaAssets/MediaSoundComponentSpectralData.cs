using Script.CoreUObject;
using Script.Library;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaSoundComponentSpectralData")]
	public partial class FMediaSoundComponentSpectralData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MediaAssets.MediaSoundComponentSpectralData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMediaSoundComponentSpectralData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMediaSoundComponentSpectralData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMediaSoundComponentSpectralData A, FMediaSoundComponentSpectralData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMediaSoundComponentSpectralData A, FMediaSoundComponentSpectralData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMediaSoundComponentSpectralData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float FrequencyHz
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FrequencyHz, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FrequencyHz, __InBuffer);
				}
			}
		}

		public float Magnitude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Magnitude, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Magnitude, __InBuffer);
				}
			}
		}

		private static uint __FrequencyHz = 0;

		private static uint __Magnitude = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}