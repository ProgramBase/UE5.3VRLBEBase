using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_PoseHandler")]
	public partial class FAnimNode_PoseHandler : FAnimNode_AssetPlayerBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_PoseHandler");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_PoseHandler()
		{
		}

		public static bool operator ==(FAnimNode_PoseHandler A, FAnimNode_PoseHandler B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_PoseHandler A, FAnimNode_PoseHandler B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_PoseHandler;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UPoseAsset PoseAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PoseAsset, __ReturnBuffer);

					return *(UPoseAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PoseAsset, __InBuffer);
				}
			}
		}

		private static uint __PoseAsset = 0;

	}
}