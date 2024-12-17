using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VoiceSettings")]
	public partial class FVoiceSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.VoiceSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVoiceSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FVoiceSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FVoiceSettings A, FVoiceSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVoiceSettings A, FVoiceSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVoiceSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public USceneComponent ComponentToAttachTo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentToAttachTo, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentToAttachTo, __InBuffer);
				}
			}
		}

		public USoundAttenuation AttenuationSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AttenuationSettings, __ReturnBuffer);

					return *(USoundAttenuation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AttenuationSettings, __InBuffer);
				}
			}
		}

		public USoundEffectSourcePresetChain SourceEffectChain
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceEffectChain, __ReturnBuffer);

					return *(USoundEffectSourcePresetChain*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceEffectChain, __InBuffer);
				}
			}
		}

		private static uint __ComponentToAttachTo = 0;

		private static uint __AttenuationSettings = 0;

		private static uint __SourceEffectChain = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}