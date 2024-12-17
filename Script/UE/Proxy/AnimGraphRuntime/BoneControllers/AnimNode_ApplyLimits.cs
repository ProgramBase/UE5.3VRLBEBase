using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_ApplyLimits")]
	public partial class FAnimNode_ApplyLimits : FAnimNode_SkeletalControlBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_ApplyLimits");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_ApplyLimits()
		{
		}

		public static bool operator ==(FAnimNode_ApplyLimits A, FAnimNode_ApplyLimits B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_ApplyLimits A, FAnimNode_ApplyLimits B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_ApplyLimits;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FAngularRangeLimit> AngularRangeLimits
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AngularRangeLimits, __ReturnBuffer);

					return *(TArray<FAngularRangeLimit>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AngularRangeLimits, __InBuffer);
				}
			}
		}

		public TArray<FVector> AngularOffsets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AngularOffsets, __ReturnBuffer);

					return *(TArray<FVector>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AngularOffsets, __InBuffer);
				}
			}
		}

		private static uint __AngularRangeLimits = 0;

		private static uint __AngularOffsets = 0;

	}
}