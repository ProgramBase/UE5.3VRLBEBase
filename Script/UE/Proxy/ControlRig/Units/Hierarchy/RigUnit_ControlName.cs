using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_ControlName")]
	public partial class FRigUnit_ControlName : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_ControlName");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ControlName()
		{
		}

		public static bool operator ==(FRigUnit_ControlName A, FRigUnit_ControlName B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ControlName A, FRigUnit_ControlName B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ControlName;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Control
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Control, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Control, __InBuffer);
				}
			}
		}

		private static uint __Control = 0;

	}
}