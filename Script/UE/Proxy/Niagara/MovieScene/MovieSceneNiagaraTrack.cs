﻿using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.MovieSceneNiagaraTrack")]
	public partial class UMovieSceneNiagaraTrack : UMovieSceneNameableTrack, IStaticClass
	{
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Sections, __ReturnBuffer);

					return *(TArray<UMovieSceneSection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Sections, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.MovieSceneNiagaraTrack");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Sections = 0;
	}
}