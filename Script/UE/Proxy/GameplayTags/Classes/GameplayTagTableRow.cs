using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.GameplayTagTableRow")]
	public partial class FGameplayTagTableRow : FTableRowBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayTags.GameplayTagTableRow");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayTagTableRow()
		{
		}

		public static bool operator ==(FGameplayTagTableRow A, FGameplayTagTableRow B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayTagTableRow A, FGameplayTagTableRow B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayTagTableRow;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Tag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tag, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tag, __InBuffer);
				}
			}
		}

		public FString DevComment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DevComment, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DevComment, __InBuffer);
				}
			}
		}

		private static uint __Tag = 0;

		private static uint __DevComment = 0;

	}
}