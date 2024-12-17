using Script.CoreUObject;
using Script.Library;
using Script.AnimationCore;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_AimConstraint_AdvancedSettings")]
	public partial class FRigUnit_AimConstraint_AdvancedSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_AimConstraint_AdvancedSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_AimConstraint_AdvancedSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_AimConstraint_AdvancedSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_AimConstraint_AdvancedSettings A, FRigUnit_AimConstraint_AdvancedSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_AimConstraint_AdvancedSettings A, FRigUnit_AimConstraint_AdvancedSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_AimConstraint_AdvancedSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigUnit_AimBone_DebugSettings DebugSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DebugSettings, __ReturnBuffer);

					return *(FRigUnit_AimBone_DebugSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DebugSettings, __InBuffer);
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

		private static uint __DebugSettings = 0;

		private static uint __RotationOrderForFilter = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}