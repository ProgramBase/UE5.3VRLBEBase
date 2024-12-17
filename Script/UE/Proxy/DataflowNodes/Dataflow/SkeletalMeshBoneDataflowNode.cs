using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Engine;

namespace Script.DataflowNodes
{
	[PathName("/Script/DataflowNodes.SkeletalMeshBoneDataflowNode")]
	public partial class FSkeletalMeshBoneDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowNodes.SkeletalMeshBoneDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkeletalMeshBoneDataflowNode()
		{
		}

		public static bool operator ==(FSkeletalMeshBoneDataflowNode A, FSkeletalMeshBoneDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkeletalMeshBoneDataflowNode A, FSkeletalMeshBoneDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkeletalMeshBoneDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName BoneName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneName, __InBuffer);
				}
			}
		}

		public USkeletalMesh SkeletalMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SkeletalMesh, __ReturnBuffer);

					return *(USkeletalMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SkeletalMesh, __InBuffer);
				}
			}
		}

		public int BoneIndexOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneIndexOut, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneIndexOut, __InBuffer);
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

		private static uint __BoneName = 0;

		private static uint __SkeletalMesh = 0;

		private static uint __BoneIndexOut = 0;

		private static uint __PropertyName = 0;

	}
}