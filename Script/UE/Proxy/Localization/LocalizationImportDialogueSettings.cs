using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.LocalizationImportDialogueSettings")]
	public partial class FLocalizationImportDialogueSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Localization.LocalizationImportDialogueSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLocalizationImportDialogueSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLocalizationImportDialogueSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLocalizationImportDialogueSettings A, FLocalizationImportDialogueSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLocalizationImportDialogueSettings A, FLocalizationImportDialogueSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLocalizationImportDialogueSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDirectoryPath RawAudioPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RawAudioPath, __ReturnBuffer);

					return *(FDirectoryPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RawAudioPath, __InBuffer);
				}
			}
		}

		public FString ImportedDialogueFolder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImportedDialogueFolder, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImportedDialogueFolder, __InBuffer);
				}
			}
		}

		public bool bImportNativeAsSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bImportNativeAsSource, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bImportNativeAsSource, __InBuffer);
				}
			}
		}

		private static uint __RawAudioPath = 0;

		private static uint __ImportedDialogueFolder = 0;

		private static uint __bImportNativeAsSource = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}