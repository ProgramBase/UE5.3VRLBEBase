using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_UnsetCurveValue")]
	public partial class FRigUnit_UnsetCurveValue : FRigUnitMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_UnsetCurveValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_UnsetCurveValue()
		{
		}

		public static bool operator ==(FRigUnit_UnsetCurveValue A, FRigUnit_UnsetCurveValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_UnsetCurveValue A, FRigUnit_UnsetCurveValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_UnsetCurveValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Curve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Curve, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Curve, __InBuffer);
				}
			}
		}

		public FCachedRigElement CachedCurveIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CachedCurveIndex, __ReturnBuffer);

					return *(FCachedRigElement*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CachedCurveIndex, __InBuffer);
				}
			}
		}

		private static uint __Curve = 0;

		private static uint __CachedCurveIndex = 0;

	}
}