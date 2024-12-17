using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkAnimationFrameData")]
	public partial class FLiveLinkAnimationFrameData : FLiveLinkBaseFrameData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkAnimationFrameData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkAnimationFrameData()
		{
		}

		public static bool operator ==(FLiveLinkAnimationFrameData A, FLiveLinkAnimationFrameData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkAnimationFrameData A, FLiveLinkAnimationFrameData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkAnimationFrameData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FTransform> Transforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Transforms, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Transforms, __InBuffer);
				}
			}
		}

		private static uint __Transforms = 0;

	}
}