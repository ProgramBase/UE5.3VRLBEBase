using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.RestrictedGameplayTagTableRow")]
	public partial class FRestrictedGameplayTagTableRow : FGameplayTagTableRow, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayTags.RestrictedGameplayTagTableRow");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRestrictedGameplayTagTableRow()
		{
		}

		public static bool operator ==(FRestrictedGameplayTagTableRow A, FRestrictedGameplayTagTableRow B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRestrictedGameplayTagTableRow A, FRestrictedGameplayTagTableRow B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRestrictedGameplayTagTableRow;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bAllowNonRestrictedChildren
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowNonRestrictedChildren, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowNonRestrictedChildren, __InBuffer);
				}
			}
		}

		private static uint __bAllowNonRestrictedChildren = 0;

	}
}