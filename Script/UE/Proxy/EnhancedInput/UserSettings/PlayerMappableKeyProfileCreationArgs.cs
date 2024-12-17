using Script.CoreUObject;
using Script.Library;
using Script.GameplayTags;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.PlayerMappableKeyProfileCreationArgs")]
	public partial class FPlayerMappableKeyProfileCreationArgs : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EnhancedInput.PlayerMappableKeyProfileCreationArgs");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlayerMappableKeyProfileCreationArgs() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlayerMappableKeyProfileCreationArgs() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlayerMappableKeyProfileCreationArgs A, FPlayerMappableKeyProfileCreationArgs B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlayerMappableKeyProfileCreationArgs A, FPlayerMappableKeyProfileCreationArgs B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlayerMappableKeyProfileCreationArgs;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UEnhancedPlayerMappableKeyProfile> ProfileType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProfileType, __ReturnBuffer);

					return *(TSubclassOf<UEnhancedPlayerMappableKeyProfile>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProfileType, __InBuffer);
				}
			}
		}

		public FGameplayTag ProfileIdentifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProfileIdentifier, __ReturnBuffer);

					return *(FGameplayTag*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProfileIdentifier, __InBuffer);
				}
			}
		}

		public FPlatformUserId UserId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserId, __ReturnBuffer);

					return *(FPlatformUserId*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserId, __InBuffer);
				}
			}
		}

		public FText DisplayName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DisplayName, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DisplayName, __InBuffer);
				}
			}
		}

		public bool bSetAsCurrentProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSetAsCurrentProfile, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSetAsCurrentProfile, __InBuffer);
				}
			}
		}

		private static uint __ProfileType = 0;

		private static uint __ProfileIdentifier = 0;

		private static uint __UserId = 0;

		private static uint __DisplayName = 0;

		private static uint __bSetAsCurrentProfile = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}