﻿using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCacheTracks
{
	[PathName("/Script/GeometryCacheTracks.MovieSceneGeometryCacheSectionTemplateParameters")]
	public partial class FMovieSceneGeometryCacheSectionTemplateParameters : FMovieSceneGeometryCacheParams, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCacheTracks.MovieSceneGeometryCacheSectionTemplateParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneGeometryCacheSectionTemplateParameters()
		{
		}

		public static bool operator ==(FMovieSceneGeometryCacheSectionTemplateParameters A, FMovieSceneGeometryCacheSectionTemplateParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneGeometryCacheSectionTemplateParameters A, FMovieSceneGeometryCacheSectionTemplateParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneGeometryCacheSectionTemplateParameters;

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

	}
}