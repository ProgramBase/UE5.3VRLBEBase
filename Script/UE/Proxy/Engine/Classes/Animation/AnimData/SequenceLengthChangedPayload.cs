using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SequenceLengthChangedPayload")]
	public partial class FSequenceLengthChangedPayload : FEmptyPayload, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SequenceLengthChangedPayload");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSequenceLengthChangedPayload()
		{
		}

		public static bool operator ==(FSequenceLengthChangedPayload A, FSequenceLengthChangedPayload B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSequenceLengthChangedPayload A, FSequenceLengthChangedPayload B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSequenceLengthChangedPayload;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float PreviousLength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PreviousLength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PreviousLength, __InBuffer);
				}
			}
		}

		public float T0
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __T0, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __T0, __InBuffer);
				}
			}
		}

		public float T1
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __T1, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __T1, __InBuffer);
				}
			}
		}

		public FFrameNumber PreviousNumberOfFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PreviousNumberOfFrames, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PreviousNumberOfFrames, __InBuffer);
				}
			}
		}

		public FFrameNumber Frame0
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Frame0, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Frame0, __InBuffer);
				}
			}
		}

		public FFrameNumber Frame1
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Frame1, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Frame1, __InBuffer);
				}
			}
		}

		private static uint __PreviousLength = 0;

		private static uint __T0 = 0;

		private static uint __T1 = 0;

		private static uint __PreviousNumberOfFrames = 0;

		private static uint __Frame0 = 0;

		private static uint __Frame1 = 0;

	}
}