using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.MovieSceneNiagaraVectorParameterTrack")]
	public partial class UMovieSceneNiagaraVectorParameterTrack : UMovieSceneNiagaraParameterTrack, IStaticClass, IMovieSceneTrackTemplateProducer
	{
		public int ChannelsUsed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChannelsUsed, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChannelsUsed, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.MovieSceneNiagaraVectorParameterTrack");
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

		private static uint __ChannelsUsed = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}