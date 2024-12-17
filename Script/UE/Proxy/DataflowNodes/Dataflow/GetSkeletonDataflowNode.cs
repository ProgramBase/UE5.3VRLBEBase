using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Engine;

namespace Script.DataflowNodes
{
	[PathName("/Script/DataflowNodes.GetSkeletonDataflowNode")]
	public partial class FGetSkeletonDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowNodes.GetSkeletonDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetSkeletonDataflowNode()
		{
		}

		public static bool operator ==(FGetSkeletonDataflowNode A, FGetSkeletonDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetSkeletonDataflowNode A, FGetSkeletonDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetSkeletonDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public USkeleton Skeleton
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Skeleton, __ReturnBuffer);

					return *(USkeleton*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Skeleton, __InBuffer);
				}
			}
		}

		public FName PropertyName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyName, __InBuffer);
				}
			}
		}

		private static uint __Skeleton = 0;

		private static uint __PropertyName = 0;

	}
}