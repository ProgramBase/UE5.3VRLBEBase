using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkCameraBlueprintData")]
	public partial class FLiveLinkCameraBlueprintData : FLiveLinkBaseBlueprintData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkCameraBlueprintData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkCameraBlueprintData()
		{
		}

		public static bool operator ==(FLiveLinkCameraBlueprintData A, FLiveLinkCameraBlueprintData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkCameraBlueprintData A, FLiveLinkCameraBlueprintData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkCameraBlueprintData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLiveLinkCameraStaticData StaticData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticData, __ReturnBuffer);

					return *(FLiveLinkCameraStaticData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StaticData, __InBuffer);
				}
			}
		}

		public FLiveLinkCameraFrameData FrameData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FrameData, __ReturnBuffer);

					return *(FLiveLinkCameraFrameData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FrameData, __InBuffer);
				}
			}
		}

		private static uint __StaticData = 0;

		private static uint __FrameData = 0;

	}
}