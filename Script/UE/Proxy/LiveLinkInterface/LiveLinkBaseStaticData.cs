using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkBaseStaticData")]
	public partial class FLiveLinkBaseStaticData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkBaseStaticData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkBaseStaticData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLiveLinkBaseStaticData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLiveLinkBaseStaticData A, FLiveLinkBaseStaticData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkBaseStaticData A, FLiveLinkBaseStaticData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkBaseStaticData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> PropertyNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyNames, __InBuffer);
				}
			}
		}

		private static uint __PropertyNames = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}