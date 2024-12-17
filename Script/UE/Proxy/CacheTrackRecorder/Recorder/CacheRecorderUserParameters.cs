using Script.CoreUObject;
using Script.Library;

namespace Script.CacheTrackRecorder
{
	[PathName("/Script/CacheTrackRecorder.CacheRecorderUserParameters")]
	public partial class FCacheRecorderUserParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CacheTrackRecorder.CacheRecorderUserParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCacheRecorderUserParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCacheRecorderUserParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCacheRecorderUserParameters A, FCacheRecorderUserParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCacheRecorderUserParameters A, FCacheRecorderUserParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCacheRecorderUserParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bMaximizeViewport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bMaximizeViewport, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bMaximizeViewport, __InBuffer);
				}
			}
		}

		public float EngineTimeDilation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EngineTimeDilation, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EngineTimeDilation, __InBuffer);
				}
			}
		}

		public bool bResetPlayhead
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bResetPlayhead, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bResetPlayhead, __InBuffer);
				}
			}
		}

		public bool bStopAtPlaybackEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bStopAtPlaybackEnd, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bStopAtPlaybackEnd, __InBuffer);
				}
			}
		}

		private static uint __bMaximizeViewport = 0;

		private static uint __EngineTimeDilation = 0;

		private static uint __bResetPlayhead = 0;

		private static uint __bStopAtPlaybackEnd = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}