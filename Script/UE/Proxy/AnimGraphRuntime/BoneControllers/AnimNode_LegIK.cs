using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_LegIK")]
	public partial class FAnimNode_LegIK : FAnimNode_SkeletalControlBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_LegIK");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_LegIK()
		{
		}

		public static bool operator ==(FAnimNode_LegIK A, FAnimNode_LegIK B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_LegIK A, FAnimNode_LegIK B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_LegIK;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float ReachPrecision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReachPrecision, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReachPrecision, __InBuffer);
				}
			}
		}

		public int MaxIterations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxIterations, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxIterations, __InBuffer);
				}
			}
		}

		public TArray<FAnimLegIKDefinition> LegsDefinition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LegsDefinition, __ReturnBuffer);

					return *(TArray<FAnimLegIKDefinition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LegsDefinition, __InBuffer);
				}
			}
		}

		private static uint __ReachPrecision = 0;

		private static uint __MaxIterations = 0;

		private static uint __LegsDefinition = 0;

	}
}