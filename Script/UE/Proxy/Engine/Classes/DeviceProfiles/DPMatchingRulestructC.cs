using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DPMatchingRulestructC")]
	public partial class FDPMatchingRulestructC : FDPMatchingRulestructBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DPMatchingRulestructC");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDPMatchingRulestructC()
		{
		}

		public static bool operator ==(FDPMatchingRulestructC A, FDPMatchingRulestructC B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDPMatchingRulestructC A, FDPMatchingRulestructC B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDPMatchingRulestructC;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FDPMatchingRulestructB> OnTrue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OnTrue, __ReturnBuffer);

					return *(TArray<FDPMatchingRulestructB>*)__ReturnBuffer;
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

		public TArray<FDPMatchingRulestructB> OnFalse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OnFalse, __ReturnBuffer);

					return *(TArray<FDPMatchingRulestructB>*)__ReturnBuffer;
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