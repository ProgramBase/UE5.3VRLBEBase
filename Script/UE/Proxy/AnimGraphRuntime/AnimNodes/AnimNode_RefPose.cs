using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_RefPose")]
	public partial class FAnimNode_RefPose : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_RefPose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_RefPose()
		{
		}

		public static bool operator ==(FAnimNode_RefPose A, FAnimNode_RefPose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_RefPose A, FAnimNode_RefPose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_RefPose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ERefPoseType RefPoseType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RefPoseType, __ReturnBuffer);

					return *(ERefPoseType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RefPoseType, __InBuffer);
				}
			}
		}

		private static uint __RefPoseType = 0;

	}
}