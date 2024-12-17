using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.CacheTrackRecorder
{
	[PathName("/Script/CacheTrackRecorder.CacheRecorderProjectParameters")]
	public partial class FCacheRecorderProjectParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CacheTrackRecorder.CacheRecorderProjectParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCacheRecorderProjectParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCacheRecorderProjectParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCacheRecorderProjectParameters A, FCacheRecorderProjectParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCacheRecorderProjectParameters A, FCacheRecorderProjectParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCacheRecorderProjectParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString DefaultSlate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultSlate, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultSlate, __InBuffer);
				}
			}
		}

		public bool bCacheTrackRecorderControlsClockTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCacheTrackRecorderControlsClockTime, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCacheTrackRecorderControlsClockTime, __InBuffer);
				}
			}
		}

		public EUpdateClockSource RecordingClockSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RecordingClockSource, __ReturnBuffer);

					return *(EUpdateClockSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RecordingClockSource, __InBuffer);
				}
			}
		}

		public bool bStartAtCurrentTimecode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bStartAtCurrentTimecode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bStartAtCurrentTimecode, __InBuffer);
				}
			}
		}

		public bool bRecordTimecode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRecordTimecode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRecordTimecode, __InBuffer);
				}
			}
		}

		public bool bShowNotifications
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowNotifications, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowNotifications, __InBuffer);
				}
			}
		}

		private static uint __DefaultSlate = 0;

		private static uint __bCacheTrackRecorderControlsClockTime = 0;

		private static uint __RecordingClockSource = 0;

		private static uint __bStartAtCurrentTimecode = 0;

		private static uint __bRecordTimecode = 0;

		private static uint __bShowNotifications = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}