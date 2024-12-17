using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.MovieSceneControlRigSpaceChannel")]
	public partial class FMovieSceneControlRigSpaceChannel : FMovieSceneChannel, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.MovieSceneControlRigSpaceChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneControlRigSpaceChannel()
		{
		}

		public static bool operator ==(FMovieSceneControlRigSpaceChannel A, FMovieSceneControlRigSpaceChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneControlRigSpaceChannel A, FMovieSceneControlRigSpaceChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneControlRigSpaceChannel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FFrameNumber> KeyTimes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyTimes, __ReturnBuffer);

					return *(TArray<FFrameNumber>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeyTimes, __InBuffer);
				}
			}
		}

		public TArray<FMovieSceneControlRigSpaceBaseKey> KeyValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyValues, __ReturnBuffer);

					return *(TArray<FMovieSceneControlRigSpaceBaseKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeyValues, __InBuffer);
				}
			}
		}

		public FMovieSceneKeyHandleMap KeyHandles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyHandles, __ReturnBuffer);

					return *(FMovieSceneKeyHandleMap*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeyHandles, __InBuffer);
				}
			}
		}

		private static uint __KeyTimes = 0;

		private static uint __KeyValues = 0;

		private static uint __KeyHandles = 0;

	}
}