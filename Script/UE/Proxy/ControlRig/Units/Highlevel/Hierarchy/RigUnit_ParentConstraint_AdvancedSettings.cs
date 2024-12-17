using Script.CoreUObject;
using Script.Library;
using Script.AnimationCore;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_ParentConstraint_AdvancedSettings")]
	public partial class FRigUnit_ParentConstraint_AdvancedSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_ParentConstraint_AdvancedSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ParentConstraint_AdvancedSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_ParentConstraint_AdvancedSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_ParentConstraint_AdvancedSettings A, FRigUnit_ParentConstraint_AdvancedSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ParentConstraint_AdvancedSettings A, FRigUnit_ParentConstraint_AdvancedSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ParentConstraint_AdvancedSettings;

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