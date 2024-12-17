using Script.CoreUObject;
using Script.Library;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.SubmixEffectSubmixEQSettings")]
	public partial class FSubmixEffectSubmixEQSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioMixer.SubmixEffectSubmixEQSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSubmixEffectSubmixEQSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSubmixEffectSubmixEQSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSubmixEffectSubmixEQSettings A, FSubmixEffectSubmixEQSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSubmixEffectSubmixEQSettings A, FSubmixEffectSubmixEQSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSubmixEffectSubmixEQSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FSubmixEffectEQBand> EQBands
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EQBands, __ReturnBuffer);

					return *(TArray<FSubmixEffectEQBand>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EQBands, __InBuffer);
				}
			}
		}

		private static uint __EQBands = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}