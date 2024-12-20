﻿using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EMovieSceneBuiltInEasing")]
	public enum EMovieSceneBuiltInEasing : byte
	{
		Linear = 0,
		SinIn = 1,
		SinOut = 2,
		SinInOut = 3,
		QuadIn = 4,
		QuadOut = 5,
		QuadInOut = 6,
		Cubic = 7,
		CubicIn = 8,
		CubicOut = 9,
		CubicInOut = 10,
		HermiteCubicInOut = 11,
		QuartIn = 12,
		QuartOut = 13,
		QuartInOut = 14,
		QuintIn = 15,
		QuintOut = 16,
		QuintInOut = 17,
		ExpoIn = 18,
		ExpoOut = 19,
		ExpoInOut = 20,
		CircIn = 21,
		CircOut = 22,
		CircInOut = 23,
		Custom = 24,
	}
}