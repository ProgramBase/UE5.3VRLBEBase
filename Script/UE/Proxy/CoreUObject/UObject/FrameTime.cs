using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.FrameTime")]
	public partial class FFrameTime : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.FrameTime");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFrameTime() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFrameTime() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFrameTime A, FFrameTime B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFrameTime A, FFrameTime B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFrameTime;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFrameNumber FrameNumber
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FrameNumber, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FrameNumber, __InBuffer);
				}
			}
		}

		public float SubFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SubFrame, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SubFrame, __InBuffer);
				}
			}
		}

		private static uint __FrameNumber = 0;

		private static uint __SubFrame = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}