using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.SplineIKCachedBoneData")]
	public partial class FSplineIKCachedBoneData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.SplineIKCachedBoneData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSplineIKCachedBoneData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSplineIKCachedBoneData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSplineIKCachedBoneData A, FSplineIKCachedBoneData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSplineIKCachedBoneData A, FSplineIKCachedBoneData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSplineIKCachedBoneData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FBoneReference Bone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bone, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
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

		public int RefSkeletonIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RefSkeletonIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RefSkeletonIndex, __InBuffer);
				}
			}
		}

		private static uint __Bone = 0;

		private static uint __RefSkeletonIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}