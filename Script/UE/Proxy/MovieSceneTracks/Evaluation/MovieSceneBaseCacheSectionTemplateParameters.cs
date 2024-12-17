using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneBaseCacheSectionTemplateParameters")]
	public partial class FMovieSceneBaseCacheSectionTemplateParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneBaseCacheSectionTemplateParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneBaseCacheSectionTemplateParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneBaseCacheSectionTemplateParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneBaseCacheSectionTemplateParameters A, FMovieSceneBaseCacheSectionTemplateParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneBaseCacheSectionTemplateParameters A, FMovieSceneBaseCacheSectionTemplateParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneBaseCacheSectionTemplateParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFrameNumber SectionStartTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SectionStartTime, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SectionStartTime, __InBuffer);
				}
			}
		}

		public FFrameNumber SectionEndTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SectionEndTime, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SectionEndTime, __InBuffer);
				}
			}
		}

		private static uint __SectionStartTime = 0;

		private static uint __SectionEndTime = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}