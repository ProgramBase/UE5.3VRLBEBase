using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.MovieSceneNiagaraEmitterSection")]
	public partial class UMovieSceneNiagaraEmitterSection : UMovieSceneNiagaraEmitterSectionBase, IStaticClass
	{
		public int NumLoops
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumLoops, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumLoops, __InBuffer);
				}
			}
		}

		public bool bStartTimeIncludedInFirstLoopOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStartTimeIncludedInFirstLoopOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStartTimeIncludedInFirstLoopOnly, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.MovieSceneNiagaraEmitterSection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NumLoops = 0;

		private static uint __bStartTimeIncludedInFirstLoopOnly = 0;
	}
}