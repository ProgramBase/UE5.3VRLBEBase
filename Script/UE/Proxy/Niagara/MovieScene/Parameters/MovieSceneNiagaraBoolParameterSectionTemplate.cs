using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.MovieSceneNiagaraBoolParameterSectionTemplate")]
	public partial class FMovieSceneNiagaraBoolParameterSectionTemplate : FMovieSceneNiagaraParameterSectionTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.MovieSceneNiagaraBoolParameterSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneNiagaraBoolParameterSectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneNiagaraBoolParameterSectionTemplate A, FMovieSceneNiagaraBoolParameterSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneNiagaraBoolParameterSectionTemplate A, FMovieSceneNiagaraBoolParameterSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneNiagaraBoolParameterSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneBoolChannel BoolChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoolChannel, __ReturnBuffer);

					return *(FMovieSceneBoolChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoolChannel, __InBuffer);
				}
			}
		}

		private static uint __BoolChannel = 0;

	}
}