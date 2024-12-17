using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTrackEvaluationFieldEntry")]
	public partial class FMovieSceneTrackEvaluationFieldEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTrackEvaluationFieldEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTrackEvaluationFieldEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTrackEvaluationFieldEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTrackEvaluationFieldEntry A, FMovieSceneTrackEvaluationFieldEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTrackEvaluationFieldEntry A, FMovieSceneTrackEvaluationFieldEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTrackEvaluationFieldEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMovieSceneSection Section
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Section, __ReturnBuffer);

					return *(UMovieSceneSection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Section, __InBuffer);
				}
			}
		}

		public FFrameNumberRange Range
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Range, __ReturnBuffer);

					return *(FFrameNumberRange*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Range, __InBuffer);
				}
			}
		}

		public FFrameNumber ForcedTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ForcedTime, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ForcedTime, __InBuffer);
				}
			}
		}

		public ESectionEvaluationFlags Flags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Flags, __ReturnBuffer);

					return *(ESectionEvaluationFlags*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Flags, __InBuffer);
				}
			}
		}

		public short LegacySortOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LegacySortOrder, __ReturnBuffer);

					return *(short*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(short*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LegacySortOrder, __InBuffer);
				}
			}
		}

		private static uint __Section = 0;

		private static uint __Range = 0;

		private static uint __ForcedTime = 0;

		private static uint __Flags = 0;

		private static uint __LegacySortOrder = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}