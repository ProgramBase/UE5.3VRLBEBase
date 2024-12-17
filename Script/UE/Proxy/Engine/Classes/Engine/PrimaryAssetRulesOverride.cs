using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PrimaryAssetRulesOverride")]
	public partial class FPrimaryAssetRulesOverride : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PrimaryAssetRulesOverride");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPrimaryAssetRulesOverride() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPrimaryAssetRulesOverride() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPrimaryAssetRulesOverride A, FPrimaryAssetRulesOverride B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPrimaryAssetRulesOverride A, FPrimaryAssetRulesOverride B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPrimaryAssetRulesOverride;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPrimaryAssetId PrimaryAssetId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetId, __ReturnBuffer);

					return *(FPrimaryAssetId*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetId, __InBuffer);
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

		private static uint __PrimaryAssetId = 0;

		private static uint __Rules = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}