using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_UseCachedPose")]
	public partial class FAnimNode_UseCachedPose : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_UseCachedPose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_UseCachedPose()
		{
		}

		public static bool operator ==(FAnimNode_UseCachedPose A, FAnimNode_UseCachedPose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_UseCachedPose A, FAnimNode_UseCachedPose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_UseCachedPose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPoseLink LinkToCachingNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LinkToCachingNode, __ReturnBuffer);

					return *(FPoseLink*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LinkToCachingNode, __InBuffer);
				}
			}
		}

		public FName CachePoseName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CachePoseName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CachePoseName, __InBuffer);
				}
			}
		}

		private static uint __LinkToCachingNode = 0;

		private static uint __CachePoseName = 0;

	}
}