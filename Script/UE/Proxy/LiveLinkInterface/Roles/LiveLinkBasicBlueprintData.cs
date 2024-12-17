using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkBasicBlueprintData")]
	public partial class FLiveLinkBasicBlueprintData : FLiveLinkBaseBlueprintData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkBasicBlueprintData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkBasicBlueprintData()
		{
		}

		public static bool operator ==(FLiveLinkBasicBlueprintData A, FLiveLinkBasicBlueprintData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkBasicBlueprintData A, FLiveLinkBasicBlueprintData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkBasicBlueprintData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLiveLinkBaseStaticData StaticData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticData, __ReturnBuffer);

					return *(FLiveLinkBaseStaticData*)__ReturnBuffer;
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

		public FLiveLinkBaseFrameData FrameData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FrameData, __ReturnBuffer);

					return *(FLiveLinkBaseFrameData*)__ReturnBuffer;
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