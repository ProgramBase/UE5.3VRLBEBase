using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.GameplayTagRedirect")]
	public partial class FGameplayTagRedirect : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayTags.GameplayTagRedirect");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayTagRedirect() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayTagRedirect() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayTagRedirect A, FGameplayTagRedirect B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayTagRedirect A, FGameplayTagRedirect B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayTagRedirect;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName OldTagName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OldTagName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OldTagName, __InBuffer);
				}
			}
		}

		public FName NewTagName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewTagName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewTagName, __InBuffer);
				}
			}
		}

		private static uint __OldTagName = 0;

		private static uint __NewTagName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}