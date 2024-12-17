using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkLightBlueprintData")]
	public partial class FLiveLinkLightBlueprintData : FLiveLinkBaseBlueprintData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkLightBlueprintData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkLightBlueprintData()
		{
		}

		public static bool operator ==(FLiveLinkLightBlueprintData A, FLiveLinkLightBlueprintData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkLightBlueprintData A, FLiveLinkLightBlueprintData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkLightBlueprintData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLiveLinkLightStaticData StaticData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticData, __ReturnBuffer);

					return *(FLiveLinkLightStaticData*)__ReturnBuffer;
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

		public FLiveLinkLightFrameData FrameData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FrameData, __ReturnBuffer);

					return *(FLiveLinkLightFrameData*)__ReturnBuffer;
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