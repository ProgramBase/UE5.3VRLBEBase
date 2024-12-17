using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkInterpolationSettings")]
	public partial class FLiveLinkInterpolationSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkInterpolationSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkInterpolationSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLiveLinkInterpolationSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLiveLinkInterpolationSettings A, FLiveLinkInterpolationSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkInterpolationSettings A, FLiveLinkInterpolationSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkInterpolationSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float InterpolationOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterpolationOffset, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InterpolationOffset, __InBuffer);
				}
			}
		}

		private static uint __InterpolationOffset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}