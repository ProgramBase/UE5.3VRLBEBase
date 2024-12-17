using Script.CoreUObject;
using Script.Library;
using Script.AnimationCore;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_ConvertEulerTransform")]
	public partial class FRigUnit_ConvertEulerTransform : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_ConvertEulerTransform");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ConvertEulerTransform()
		{
		}

		public static bool operator ==(FRigUnit_ConvertEulerTransform A, FRigUnit_ConvertEulerTransform B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ConvertEulerTransform A, FRigUnit_ConvertEulerTransform B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ConvertEulerTransform;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FEulerTransform Input
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Input, __ReturnBuffer);

					return *(FEulerTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Input, __InBuffer);
				}
			}
		}

		public FTransform Result
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Result, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Result, __InBuffer);
				}
			}
		}

		private static uint __Input = 0;

		private static uint __Result = 0;

	}
}