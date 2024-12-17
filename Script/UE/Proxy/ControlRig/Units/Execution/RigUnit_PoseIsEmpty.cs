using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_PoseIsEmpty")]
	public partial class FRigUnit_PoseIsEmpty : FRigUnit_HierarchyBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_PoseIsEmpty");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_PoseIsEmpty()
		{
		}

		public static bool operator ==(FRigUnit_PoseIsEmpty A, FRigUnit_PoseIsEmpty B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_PoseIsEmpty A, FRigUnit_PoseIsEmpty B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_PoseIsEmpty;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigPose Pose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Pose, __ReturnBuffer);

					return *(FRigPose*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Pose, __InBuffer);
				}
			}
		}

		public bool IsEmpty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IsEmpty, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IsEmpty, __InBuffer);
				}
			}
		}

		private static uint __Pose = 0;

		private static uint __IsEmpty = 0;

	}
}