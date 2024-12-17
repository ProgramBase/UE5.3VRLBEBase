using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_Constraint")]
	public partial class FAnimNode_Constraint : FAnimNode_SkeletalControlBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_Constraint");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_Constraint()
		{
		}

		public static bool operator ==(FAnimNode_Constraint A, FAnimNode_Constraint B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_Constraint A, FAnimNode_Constraint B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_Constraint;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FBoneReference BoneToModify
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneToModify, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneToModify, __InBuffer);
				}
			}
		}

		public TArray<FConstraint> ConstraintSetup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConstraintSetup, __ReturnBuffer);

					return *(TArray<FConstraint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConstraintSetup, __InBuffer);
				}
			}
		}

		public TArray<float> ConstraintWeights
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConstraintWeights, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConstraintWeights, __InBuffer);
				}
			}
		}

		private static uint __BoneToModify = 0;

		private static uint __ConstraintSetup = 0;

		private static uint __ConstraintWeights = 0;

	}
}