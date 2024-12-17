﻿using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneCVarTrackInstance")]
	public partial class UMovieSceneCVarTrackInstance : UMovieSceneTrackInstance, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneCVarTrackInstance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}