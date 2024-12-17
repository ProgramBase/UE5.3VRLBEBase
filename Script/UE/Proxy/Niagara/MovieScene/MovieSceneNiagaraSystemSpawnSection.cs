using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.MovieSceneNiagaraSystemSpawnSection")]
	public partial class UMovieSceneNiagaraSystemSpawnSection : UMovieSceneSection, IStaticClass
	{
		public ENiagaraSystemSpawnSectionStartBehavior SectionStartBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SectionStartBehavior, __ReturnBuffer);

					return *(ENiagaraSystemSpawnSectionStartBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SectionStartBehavior, __InBuffer);
				}
			}
		}

		public ENiagaraSystemSpawnSectionEvaluateBehavior SectionEvaluateBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SectionEvaluateBehavior, __ReturnBuffer);

					return *(ENiagaraSystemSpawnSectionEvaluateBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SectionEvaluateBehavior, __InBuffer);
				}
			}
		}

		public ENiagaraSystemSpawnSectionEndBehavior SectionEndBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SectionEndBehavior, __ReturnBuffer);

					return *(ENiagaraSystemSpawnSectionEndBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SectionEndBehavior, __InBuffer);
				}
			}
		}

		public ENiagaraAgeUpdateMode AgeUpdateMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AgeUpdateMode, __ReturnBuffer);

					return *(ENiagaraAgeUpdateMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AgeUpdateMode, __InBuffer);
				}
			}
		}

		public bool bAllowScalability
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowScalability, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowScalability, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.MovieSceneNiagaraSystemSpawnSection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SectionStartBehavior = 0;

		private static uint __SectionEvaluateBehavior = 0;

		private static uint __SectionEndBehavior = 0;

		private static uint __AgeUpdateMode = 0;

		private static uint __bAllowScalability = 0;
	}
}