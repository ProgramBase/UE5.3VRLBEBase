﻿using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.MovieSceneNiagaraBoolParameterTrack")]
	public partial class UMovieSceneNiagaraBoolParameterTrack : UMovieSceneNiagaraParameterTrack, IStaticClass, IMovieSceneTrackTemplateProducer
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.MovieSceneNiagaraBoolParameterTrack");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __ExecuteUbergraph = 0;
	}
}