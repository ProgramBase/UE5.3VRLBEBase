using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.MovieSceneNiagaraVectorParameterSectionTemplate")]
	public partial class FMovieSceneNiagaraVectorParameterSectionTemplate : FMovieSceneNiagaraParameterSectionTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.MovieSceneNiagaraVectorParameterSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneNiagaraVectorParameterSectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneNiagaraVectorParameterSectionTemplate A, FMovieSceneNiagaraVectorParameterSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneNiagaraVectorParameterSectionTemplate A, FMovieSceneNiagaraVectorParameterSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneNiagaraVectorParameterSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneFloatChannel VectorChannels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VectorChannels, __ReturnBuffer);

					return *(FMovieSceneFloatChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VectorChannels, __InBuffer);
				}
			}
		}

		public int ChannelsUsed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChannelsUsed, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChannelsUsed, __InBuffer);
				}
			}
		}

		private static uint __VectorChannels = 0;

		private static uint __ChannelsUsed = 0;

	}
}