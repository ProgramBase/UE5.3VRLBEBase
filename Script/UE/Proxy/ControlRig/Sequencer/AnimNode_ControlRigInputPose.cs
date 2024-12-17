using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.AnimNode_ControlRigInputPose")]
	public partial class FAnimNode_ControlRigInputPose : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.AnimNode_ControlRigInputPose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_ControlRigInputPose()
		{
		}

		public static bool operator ==(FAnimNode_ControlRigInputPose A, FAnimNode_ControlRigInputPose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_ControlRigInputPose A, FAnimNode_ControlRigInputPose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_ControlRigInputPose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPoseLink InputPose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputPose, __ReturnBuffer);

					return *(FPoseLink*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputPose, __InBuffer);
				}
			}
		}

		private static uint __InputPose = 0;

	}
}