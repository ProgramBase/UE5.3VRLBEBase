using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AudioVolumeSubmixOverrideSettings")]
	public partial class FAudioVolumeSubmixOverrideSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AudioVolumeSubmixOverrideSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAudioVolumeSubmixOverrideSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAudioVolumeSubmixOverrideSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAudioVolumeSubmixOverrideSettings A, FAudioVolumeSubmixOverrideSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAudioVolumeSubmixOverrideSettings A, FAudioVolumeSubmixOverrideSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAudioVolumeSubmixOverrideSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public USoundSubmix Submix
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Submix, __ReturnBuffer);

					return *(USoundSubmix*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Submix, __InBuffer);
				}
			}
		}

		public TArray<USoundEffectSubmixPreset> SubmixEffectChain
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SubmixEffectChain, __ReturnBuffer);

					return *(TArray<USoundEffectSubmixPreset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SubmixEffectChain, __InBuffer);
				}
			}
		}

		public float CrossfadeTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CrossfadeTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CrossfadeTime, __InBuffer);
				}
			}
		}

		private static uint __Submix = 0;

		private static uint __SubmixEffectChain = 0;

		private static uint __CrossfadeTime = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}