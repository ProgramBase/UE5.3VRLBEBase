using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DPMatchingRulestructB")]
	public partial class FDPMatchingRulestructB : FDPMatchingRulestructBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DPMatchingRulestructB");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDPMatchingRulestructB()
		{
		}

		public static bool operator ==(FDPMatchingRulestructB A, FDPMatchingRulestructB B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDPMatchingRulestructB A, FDPMatchingRulestructB B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDPMatchingRulestructB;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FDPMatchingRulestructA> OnTrue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OnTrue, __ReturnBuffer);

					return *(TArray<FDPMatchingRulestructA>*)__ReturnBuffer;
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

		public TArray<FDPMatchingRulestructA> OnFalse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OnFalse, __ReturnBuffer);

					return *(TArray<FDPMatchingRulestructA>*)__ReturnBuffer;
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