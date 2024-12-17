using Script.CoreUObject;
using Script.Library;
using Script.AnimationCore;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_AimConstraint_WorkData")]
	public partial class FRigUnit_AimConstraint_WorkData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_AimConstraint_WorkData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_AimConstraint_WorkData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_AimConstraint_WorkData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_AimConstraint_WorkData A, FRigUnit_AimConstraint_WorkData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_AimConstraint_WorkData A, FRigUnit_AimConstraint_WorkData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_AimConstraint_WorkData;

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

		private static uint __ConstraintData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}