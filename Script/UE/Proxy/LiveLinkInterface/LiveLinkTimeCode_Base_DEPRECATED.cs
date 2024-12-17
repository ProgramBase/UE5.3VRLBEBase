using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkTimeCode_Base_DEPRECATED")]
	public partial class FLiveLinkTimeCode_Base_DEPRECATED : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkTimeCode_Base_DEPRECATED");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkTimeCode_Base_DEPRECATED() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLiveLinkTimeCode_Base_DEPRECATED() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLiveLinkTimeCode_Base_DEPRECATED A, FLiveLinkTimeCode_Base_DEPRECATED B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkTimeCode_Base_DEPRECATED A, FLiveLinkTimeCode_Base_DEPRECATED B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkTimeCode_Base_DEPRECATED;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Seconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Seconds, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Seconds, __InBuffer);
				}
			}
		}

		public int Frames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Frames, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Frames, __InBuffer);
				}
			}
		}

		public FLiveLinkFrameRate FrameRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FrameRate, __ReturnBuffer);

					return *(FLiveLinkFrameRate*)__ReturnBuffer;
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

		private static uint __Seconds = 0;

		private static uint __Frames = 0;

		private static uint __FrameRate = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}