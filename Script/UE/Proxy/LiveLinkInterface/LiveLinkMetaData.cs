using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkMetaData")]
	public partial class FLiveLinkMetaData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkMetaData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkMetaData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLiveLinkMetaData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLiveLinkMetaData A, FLiveLinkMetaData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkMetaData A, FLiveLinkMetaData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkMetaData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FName, FString> StringMetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StringMetaData, __ReturnBuffer);

					return *(TMap<FName, FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StringMetaData, __InBuffer);
				}
			}
		}

		public FQualifiedFrameTime SceneTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SceneTime, __ReturnBuffer);

					return *(FQualifiedFrameTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SceneTime, __InBuffer);
				}
			}
		}

		private static uint __StringMetaData = 0;

		private static uint __SceneTime = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}