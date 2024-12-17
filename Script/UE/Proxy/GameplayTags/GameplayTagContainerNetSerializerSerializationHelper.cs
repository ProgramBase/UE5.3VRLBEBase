using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.GameplayTagContainerNetSerializerSerializationHelper")]
	public partial class FGameplayTagContainerNetSerializerSerializationHelper : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayTags.GameplayTagContainerNetSerializerSerializationHelper");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayTagContainerNetSerializerSerializationHelper() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayTagContainerNetSerializerSerializationHelper() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayTagContainerNetSerializerSerializationHelper A, FGameplayTagContainerNetSerializerSerializationHelper B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayTagContainerNetSerializerSerializationHelper A, FGameplayTagContainerNetSerializerSerializationHelper B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayTagContainerNetSerializerSerializationHelper;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FGameplayTag> GameplayTags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameplayTags, __ReturnBuffer);

					return *(TArray<FGameplayTag>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameplayTags, __InBuffer);
				}
			}
		}

		private static uint __GameplayTags = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}