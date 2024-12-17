using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.MovieSceneNiagaraIntegerParameterSectionTemplate")]
	public partial class FMovieSceneNiagaraIntegerParameterSectionTemplate : FMovieSceneNiagaraParameterSectionTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.MovieSceneNiagaraIntegerParameterSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneNiagaraIntegerParameterSectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneNiagaraIntegerParameterSectionTemplate A, FMovieSceneNiagaraIntegerParameterSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneNiagaraIntegerParameterSectionTemplate A, FMovieSceneNiagaraIntegerParameterSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneNiagaraIntegerParameterSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneIntegerChannel IntegerChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IntegerChannel, __ReturnBuffer);

					return *(FMovieSceneIntegerChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IntegerChannel, __InBuffer);
				}
			}
		}

		private static uint __IntegerChannel = 0;

	}
}