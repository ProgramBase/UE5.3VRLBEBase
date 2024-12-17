using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.GameplayTag")]
	public partial class FGameplayTag : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayTags.GameplayTag");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayTag() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayTag() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayTag A, FGameplayTag B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayTag A, FGameplayTag B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayTag;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName TagName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TagName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TagName, __InBuffer);
				}
			}
		}

		private static uint __TagName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}