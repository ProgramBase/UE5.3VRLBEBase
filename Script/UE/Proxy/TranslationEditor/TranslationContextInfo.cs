using Script.CoreUObject;
using Script.Library;

namespace Script.TranslationEditor
{
	[PathName("/Script/TranslationEditor.TranslationContextInfo")]
	public partial class FTranslationContextInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TranslationEditor.TranslationContextInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTranslationContextInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTranslationContextInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTranslationContextInfo A, FTranslationContextInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTranslationContextInfo A, FTranslationContextInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTranslationContextInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Key
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Key, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Key, __InBuffer);
				}
			}
		}

		public FString Context
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Context, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
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

		public TArray<FTranslationChange> Changes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Changes, __ReturnBuffer);

					return *(TArray<FTranslationChange>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Changes, __InBuffer);
				}
			}
		}

		private static uint __Key = 0;

		private static uint __Context = 0;

		private static uint __Changes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}