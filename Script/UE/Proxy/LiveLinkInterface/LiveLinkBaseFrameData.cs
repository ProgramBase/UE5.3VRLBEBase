using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkBaseFrameData")]
	public partial class FLiveLinkBaseFrameData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkBaseFrameData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkBaseFrameData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLiveLinkBaseFrameData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLiveLinkBaseFrameData A, FLiveLinkBaseFrameData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkBaseFrameData A, FLiveLinkBaseFrameData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkBaseFrameData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLiveLinkWorldTime WorldTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorldTime, __ReturnBuffer);

					return *(FLiveLinkWorldTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WorldTime, __InBuffer);
				}
			}
		}

		public FLiveLinkMetaData MetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MetaData, __ReturnBuffer);

					return *(FLiveLinkMetaData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MetaData, __InBuffer);
				}
			}
		}

		public TArray<float> PropertyValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyValues, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyValues, __InBuffer);
				}
			}
		}

		private static uint __WorldTime = 0;

		private static uint __MetaData = 0;

		private static uint __PropertyValues = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}