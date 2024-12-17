using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.GameplayTagCategoryRemap")]
	public partial class FGameplayTagCategoryRemap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayTags.GameplayTagCategoryRemap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayTagCategoryRemap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayTagCategoryRemap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayTagCategoryRemap A, FGameplayTagCategoryRemap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayTagCategoryRemap A, FGameplayTagCategoryRemap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayTagCategoryRemap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString BaseCategory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BaseCategory, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BaseCategory, __InBuffer);
				}
			}
		}

		public TArray<FString> RemapCategories
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RemapCategories, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RemapCategories, __InBuffer);
				}
			}
		}

		private static uint __BaseCategory = 0;

		private static uint __RemapCategories = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}