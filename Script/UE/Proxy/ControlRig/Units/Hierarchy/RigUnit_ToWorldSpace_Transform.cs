using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_ToWorldSpace_Transform")]
	public partial class FRigUnit_ToWorldSpace_Transform : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_ToWorldSpace_Transform");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ToWorldSpace_Transform()
		{
		}

		public static bool operator ==(FRigUnit_ToWorldSpace_Transform A, FRigUnit_ToWorldSpace_Transform B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ToWorldSpace_Transform A, FRigUnit_ToWorldSpace_Transform B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ToWorldSpace_Transform;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTransform Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
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

		public FTransform World
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __World, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __World, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		private static uint __World = 0;

	}
}