using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkCurveConversionSettings")]
	public partial class FLiveLinkCurveConversionSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkCurveConversionSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkCurveConversionSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLiveLinkCurveConversionSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLiveLinkCurveConversionSettings A, FLiveLinkCurveConversionSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkCurveConversionSettings A, FLiveLinkCurveConversionSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkCurveConversionSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FString, FSoftObjectPath> CurveConversionAssetMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurveConversionAssetMap, __ReturnBuffer);

					return *(TMap<FString, FSoftObjectPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurveConversionAssetMap, __InBuffer);
				}
			}
		}

		private static uint __CurveConversionAssetMap = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}