using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.LocalizationCompilationSettings")]
	public partial class FLocalizationCompilationSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Localization.LocalizationCompilationSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLocalizationCompilationSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLocalizationCompilationSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLocalizationCompilationSettings A, FLocalizationCompilationSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLocalizationCompilationSettings A, FLocalizationCompilationSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLocalizationCompilationSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool SkipSourceCheck
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SkipSourceCheck, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SkipSourceCheck, __InBuffer);
				}
			}
		}

		public bool ValidateFormatPatterns
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ValidateFormatPatterns, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ValidateFormatPatterns, __InBuffer);
				}
			}
		}

		public bool ValidateSafeWhitespace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ValidateSafeWhitespace, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ValidateSafeWhitespace, __InBuffer);
				}
			}
		}

		private static uint __SkipSourceCheck = 0;

		private static uint __ValidateFormatPatterns = 0;

		private static uint __ValidateSafeWhitespace = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}