using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PrimaryAssetRulesCustomOverride")]
	public partial class FPrimaryAssetRulesCustomOverride : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PrimaryAssetRulesCustomOverride");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPrimaryAssetRulesCustomOverride() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPrimaryAssetRulesCustomOverride() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPrimaryAssetRulesCustomOverride A, FPrimaryAssetRulesCustomOverride B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPrimaryAssetRulesCustomOverride A, FPrimaryAssetRulesCustomOverride B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPrimaryAssetRulesCustomOverride;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPrimaryAssetType PrimaryAssetType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetType, __ReturnBuffer);

					return *(FPrimaryAssetType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetType, __InBuffer);
				}
			}
		}

		public FDirectoryPath FilterDirectory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterDirectory, __ReturnBuffer);

					return *(FDirectoryPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterDirectory, __InBuffer);
				}
			}
		}

		public FString FilterString
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterString, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterString, __InBuffer);
				}
			}
		}

		public FPrimaryAssetRules Rules
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Rules, __ReturnBuffer);

					return *(FPrimaryAssetRules*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Rules, __InBuffer);
				}
			}
		}

		private static uint __PrimaryAssetType = 0;

		private static uint __FilterDirectory = 0;

		private static uint __FilterString = 0;

		private static uint __Rules = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}