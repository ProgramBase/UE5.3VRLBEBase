using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkSkeletonStaticData")]
	public partial class FLiveLinkSkeletonStaticData : FLiveLinkBaseStaticData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkSkeletonStaticData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkSkeletonStaticData()
		{
		}

		public static bool operator ==(FLiveLinkSkeletonStaticData A, FLiveLinkSkeletonStaticData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkSkeletonStaticData A, FLiveLinkSkeletonStaticData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkSkeletonStaticData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> BoneNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneNames, __InBuffer);
				}
			}
		}

		public TArray<int> BoneParents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneParents, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneParents, __InBuffer);
				}
			}
		}

		private static uint __BoneNames = 0;

		private static uint __BoneParents = 0;

	}
}