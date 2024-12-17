using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DPMatchingRulestruct")]
	public partial class FDPMatchingRulestruct : FDPMatchingRulestructBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DPMatchingRulestruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDPMatchingRulestruct()
		{
		}

		public static bool operator ==(FDPMatchingRulestruct A, FDPMatchingRulestruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDPMatchingRulestruct A, FDPMatchingRulestruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDPMatchingRulestruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FDPMatchingRulestructE> OnTrue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OnTrue, __ReturnBuffer);

					return *(TArray<FDPMatchingRulestructE>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OnTrue, __InBuffer);
				}
			}
		}

		public TArray<FDPMatchingRulestructE> OnFalse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OnFalse, __ReturnBuffer);

					return *(TArray<FDPMatchingRulestructE>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OnFalse, __InBuffer);
				}
			}
		}

		private static uint __OnTrue = 0;

		private static uint __OnFalse = 0;

	}
}