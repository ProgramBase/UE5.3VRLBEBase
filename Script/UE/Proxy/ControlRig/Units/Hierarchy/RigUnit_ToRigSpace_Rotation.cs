using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_ToRigSpace_Rotation")]
	public partial class FRigUnit_ToRigSpace_Rotation : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_ToRigSpace_Rotation");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ToRigSpace_Rotation()
		{
		}

		public static bool operator ==(FRigUnit_ToRigSpace_Rotation A, FRigUnit_ToRigSpace_Rotation B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ToRigSpace_Rotation A, FRigUnit_ToRigSpace_Rotation B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ToRigSpace_Rotation;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FQuat Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		public FQuat Global
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Global, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Global, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		private static uint __Global = 0;

	}
}