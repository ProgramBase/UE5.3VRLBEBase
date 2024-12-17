using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.MovieSceneNiagaraFloatParameterSectionTemplate")]
	public partial class FMovieSceneNiagaraFloatParameterSectionTemplate : FMovieSceneNiagaraParameterSectionTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.MovieSceneNiagaraFloatParameterSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneNiagaraFloatParameterSectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneNiagaraFloatParameterSectionTemplate A, FMovieSceneNiagaraFloatParameterSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneNiagaraFloatParameterSectionTemplate A, FMovieSceneNiagaraFloatParameterSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneNiagaraFloatParameterSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneFloatChannel FloatChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatChannel, __ReturnBuffer);

					return *(FMovieSceneFloatChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatChannel, __InBuffer);
				}
			}
		}

		private static uint __FloatChannel = 0;

	}
}