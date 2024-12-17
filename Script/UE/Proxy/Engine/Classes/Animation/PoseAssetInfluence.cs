using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PoseAssetInfluence")]
	public partial class FPoseAssetInfluence : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PoseAssetInfluence");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPoseAssetInfluence() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPoseAssetInfluence() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPoseAssetInfluence A, FPoseAssetInfluence B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPoseAssetInfluence A, FPoseAssetInfluence B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPoseAssetInfluence;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int PoseIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PoseIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PoseIndex, __InBuffer);
				}
			}
		}

		public int BoneTransformIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneTransformIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneTransformIndex, __InBuffer);
				}
			}
		}

		private static uint __PoseIndex = 0;

		private static uint __BoneTransformIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}