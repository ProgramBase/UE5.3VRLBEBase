using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.MovieSceneNiagaraParameterTrack")]
	public partial class UMovieSceneNiagaraParameterTrack : UMovieSceneNiagaraTrack, IStaticClass
	{
		public FNiagaraVariable Parameter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Parameter, __ReturnBuffer);

					return *(FNiagaraVariable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Parameter, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.MovieSceneNiagaraParameterTrack");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Parameter = 0;
	}
}