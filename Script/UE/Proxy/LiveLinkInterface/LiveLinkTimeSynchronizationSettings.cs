using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkTimeSynchronizationSettings")]
	public partial class FLiveLinkTimeSynchronizationSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkTimeSynchronizationSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkTimeSynchronizationSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLiveLinkTimeSynchronizationSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLiveLinkTimeSynchronizationSettings A, FLiveLinkTimeSynchronizationSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkTimeSynchronizationSettings A, FLiveLinkTimeSynchronizationSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkTimeSynchronizationSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFrameRate FrameRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FrameRate, __ReturnBuffer);

					return *(FFrameRate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FrameRate, __InBuffer);
				}
			}
		}

		public FFrameNumber FrameOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FrameOffset, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FrameOffset, __InBuffer);
				}
			}
		}

		private static uint __FrameRate = 0;

		private static uint __FrameOffset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}