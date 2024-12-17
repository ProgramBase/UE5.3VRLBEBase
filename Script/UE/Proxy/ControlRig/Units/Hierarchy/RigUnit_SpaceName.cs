using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_SpaceName")]
	public partial class FRigUnit_SpaceName : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_SpaceName");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_SpaceName()
		{
		}

		public static bool operator ==(FRigUnit_SpaceName A, FRigUnit_SpaceName B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_SpaceName A, FRigUnit_SpaceName B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_SpaceName;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Space
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Space, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Space, __InBuffer);
				}
			}
		}

		private static uint __Space = 0;

	}
}