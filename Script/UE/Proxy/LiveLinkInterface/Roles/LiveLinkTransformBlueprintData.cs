using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkTransformBlueprintData")]
	public partial class FLiveLinkTransformBlueprintData : FLiveLinkBaseBlueprintData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkTransformBlueprintData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkTransformBlueprintData()
		{
		}

		public static bool operator ==(FLiveLinkTransformBlueprintData A, FLiveLinkTransformBlueprintData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkTransformBlueprintData A, FLiveLinkTransformBlueprintData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkTransformBlueprintData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLiveLinkTransformStaticData StaticData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticData, __ReturnBuffer);

					return *(FLiveLinkTransformStaticData*)__ReturnBuffer;
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

		public FLiveLinkTransformFrameData FrameData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FrameData, __ReturnBuffer);

					return *(FLiveLinkTransformFrameData*)__ReturnBuffer;
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