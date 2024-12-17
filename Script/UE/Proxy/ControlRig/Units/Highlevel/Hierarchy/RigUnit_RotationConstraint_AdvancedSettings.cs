using Script.CoreUObject;
using Script.Library;
using Script.AnimationCore;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_RotationConstraint_AdvancedSettings")]
	public partial class FRigUnit_RotationConstraint_AdvancedSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_RotationConstraint_AdvancedSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_RotationConstraint_AdvancedSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_RotationConstraint_AdvancedSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_RotationConstraint_AdvancedSettings A, FRigUnit_RotationConstraint_AdvancedSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_RotationConstraint_AdvancedSettings A, FRigUnit_RotationConstraint_AdvancedSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_RotationConstraint_AdvancedSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EConstraintInterpType InterpolationType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterpolationType, __ReturnBuffer);

					return *(EConstraintInterpType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InterpolationType, __InBuffer);
				}
			}
		}

		public EEulerRotationOrder RotationOrderForFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RotationOrderForFilter, __ReturnBuffer);

					return *(EEulerRotationOrder*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RotationOrderForFilter, __InBuffer);
				}
			}
		}

		private static uint __InterpolationType = 0;

		private static uint __RotationOrderForFilter = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}