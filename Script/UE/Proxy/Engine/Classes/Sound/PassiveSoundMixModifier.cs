using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PassiveSoundMixModifier")]
	public partial class FPassiveSoundMixModifier : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PassiveSoundMixModifier");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPassiveSoundMixModifier() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPassiveSoundMixModifier() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPassiveSoundMixModifier A, FPassiveSoundMixModifier B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPassiveSoundMixModifier A, FPassiveSoundMixModifier B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPassiveSoundMixModifier;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public USoundMix SoundMix
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SoundMix, __ReturnBuffer);

					return *(USoundMix*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SoundMix, __InBuffer);
				}
			}
		}

		public float MinVolumeThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinVolumeThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinVolumeThreshold, __InBuffer);
				}
			}
		}

		public float MaxVolumeThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxVolumeThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxVolumeThreshold, __InBuffer);
				}
			}
		}

		private static uint __SoundMix = 0;

		private static uint __MinVolumeThreshold = 0;

		private static uint __MaxVolumeThreshold = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}