using Script.CoreUObject;
using Script.Library;
using Script.AnimationCore;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_TransformConstraint_WorkData")]
	public partial class FRigUnit_TransformConstraint_WorkData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_TransformConstraint_WorkData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_TransformConstraint_WorkData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_TransformConstraint_WorkData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_TransformConstraint_WorkData A, FRigUnit_TransformConstraint_WorkData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_TransformConstraint_WorkData A, FRigUnit_TransformConstraint_WorkData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_TransformConstraint_WorkData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FConstraintData> ConstraintData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConstraintData, __ReturnBuffer);

					return *(TArray<FConstraintData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConstraintData, __InBuffer);
				}
			}
		}

		public TMap<int, int> ConstraintDataToTargets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConstraintDataToTargets, __ReturnBuffer);

					return *(TMap<int, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConstraintDataToTargets, __InBuffer);
				}
			}
		}

		private static uint __ConstraintData = 0;

		private static uint __ConstraintDataToTargets = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}