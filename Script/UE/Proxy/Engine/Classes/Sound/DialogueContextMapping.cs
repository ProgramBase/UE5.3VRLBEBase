using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DialogueContextMapping")]
	public partial class FDialogueContextMapping : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DialogueContextMapping");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDialogueContextMapping() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDialogueContextMapping() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDialogueContextMapping A, FDialogueContextMapping B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDialogueContextMapping A, FDialogueContextMapping B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDialogueContextMapping;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDialogueContext Context
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Context, __ReturnBuffer);

					return *(FDialogueContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Context, __InBuffer);
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

		public FString LocalizationKeyFormat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LocalizationKeyFormat, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LocalizationKeyFormat, __InBuffer);
				}
			}
		}

		public UDialogueSoundWaveProxy Proxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Proxy, __ReturnBuffer);

					return *(UDialogueSoundWaveProxy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Proxy, __InBuffer);
				}
			}
		}

		private static uint __Context = 0;

		private static uint __SoundWave = 0;

		private static uint __LocalizationKeyFormat = 0;

		private static uint __Proxy = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}