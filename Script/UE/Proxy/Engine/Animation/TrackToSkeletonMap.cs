using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TrackToSkeletonMap")]
	public partial class FTrackToSkeletonMap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TrackToSkeletonMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTrackToSkeletonMap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTrackToSkeletonMap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTrackToSkeletonMap A, FTrackToSkeletonMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTrackToSkeletonMap A, FTrackToSkeletonMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTrackToSkeletonMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int BoneTreeIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneTreeIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneTreeIndex, __InBuffer);
				}
			}
		}

		private static uint __BoneTreeIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}