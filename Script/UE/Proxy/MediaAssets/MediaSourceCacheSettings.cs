using Script.CoreUObject;
using Script.Library;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaSourceCacheSettings")]
	public partial class FMediaSourceCacheSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MediaAssets.MediaSourceCacheSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMediaSourceCacheSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMediaSourceCacheSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMediaSourceCacheSettings A, FMediaSourceCacheSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMediaSourceCacheSettings A, FMediaSourceCacheSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMediaSourceCacheSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverride, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverride, __InBuffer);
				}
			}
		}

		public float TimeToLookAhead
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TimeToLookAhead, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TimeToLookAhead, __InBuffer);
				}
			}
		}

		private static uint __bOverride = 0;

		private static uint __TimeToLookAhead = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}