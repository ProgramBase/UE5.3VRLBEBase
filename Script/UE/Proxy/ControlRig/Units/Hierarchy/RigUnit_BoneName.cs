using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_BoneName")]
	public partial class FRigUnit_BoneName : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_BoneName");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_BoneName()
		{
		}

		public static bool operator ==(FRigUnit_BoneName A, FRigUnit_BoneName B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_BoneName A, FRigUnit_BoneName B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_BoneName;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Bone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bone, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Bone, __InBuffer);
				}
			}
		}

		private static uint __Bone = 0;

	}
}