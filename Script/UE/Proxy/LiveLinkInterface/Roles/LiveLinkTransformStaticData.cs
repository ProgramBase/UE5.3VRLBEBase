using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkTransformStaticData")]
	public partial class FLiveLinkTransformStaticData : FLiveLinkBaseStaticData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkTransformStaticData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkTransformStaticData()
		{
		}

		public static bool operator ==(FLiveLinkTransformStaticData A, FLiveLinkTransformStaticData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkTransformStaticData A, FLiveLinkTransformStaticData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkTransformStaticData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bIsLocationSupported
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsLocationSupported, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsLocationSupported, __InBuffer);
				}
			}
		}

		public bool bIsRotationSupported
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsRotationSupported, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsRotationSupported, __InBuffer);
				}
			}
		}

		public bool bIsScaleSupported
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsScaleSupported, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsScaleSupported, __InBuffer);
				}
			}
		}

		private static uint __bIsLocationSupported = 0;

		private static uint __bIsRotationSupported = 0;

		private static uint __bIsScaleSupported = 0;

	}
}