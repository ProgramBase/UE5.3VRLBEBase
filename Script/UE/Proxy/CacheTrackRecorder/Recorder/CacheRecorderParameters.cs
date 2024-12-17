using Script.CoreUObject;
using Script.Library;

namespace Script.CacheTrackRecorder
{
	[PathName("/Script/CacheTrackRecorder.CacheRecorderParameters")]
	public partial class FCacheRecorderParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CacheTrackRecorder.CacheRecorderParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCacheRecorderParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCacheRecorderParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCacheRecorderParameters A, FCacheRecorderParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCacheRecorderParameters A, FCacheRecorderParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCacheRecorderParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FCacheRecorderUserParameters User
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __User, __ReturnBuffer);

					return *(FCacheRecorderUserParameters*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __User, __InBuffer);
				}
			}
		}

		public FCacheRecorderProjectParameters Project
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Project, __ReturnBuffer);

					return *(FCacheRecorderProjectParameters*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Project, __InBuffer);
				}
			}
		}

		public FFrameNumber StartFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StartFrame, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StartFrame, __InBuffer);
				}
			}
		}

		private static uint __User = 0;

		private static uint __Project = 0;

		private static uint __StartFrame = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}