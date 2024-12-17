using Script.CoreUObject;
using Script.Library;

namespace Script.MediaUtils
{
	[PathName("/Script/MediaUtils.MediaPlayerOptions")]
	public partial class FMediaPlayerOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MediaUtils.MediaPlayerOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMediaPlayerOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMediaPlayerOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMediaPlayerOptions A, FMediaPlayerOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMediaPlayerOptions A, FMediaPlayerOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMediaPlayerOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMediaPlayerTrackOptions Tracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tracks, __ReturnBuffer);

					return *(FMediaPlayerTrackOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tracks, __InBuffer);
				}
			}
		}

		public FTimespan SeekTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SeekTime, __ReturnBuffer);

					return *(FTimespan*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SeekTime, __InBuffer);
				}
			}
		}

		public EMediaPlayerOptionBooleanOverride PlayOnOpen
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlayOnOpen, __ReturnBuffer);

					return *(EMediaPlayerOptionBooleanOverride*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlayOnOpen, __InBuffer);
				}
			}
		}

		public EMediaPlayerOptionBooleanOverride Loop
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Loop, __ReturnBuffer);

					return *(EMediaPlayerOptionBooleanOverride*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Loop, __InBuffer);
				}
			}
		}

		private static uint __Tracks = 0;

		private static uint __SeekTime = 0;

		private static uint __PlayOnOpen = 0;

		private static uint __Loop = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}