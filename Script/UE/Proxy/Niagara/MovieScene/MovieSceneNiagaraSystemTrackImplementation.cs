using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.MovieSceneNiagaraSystemTrackImplementation")]
	public partial class FMovieSceneNiagaraSystemTrackImplementation : FMovieSceneTrackImplementation, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.MovieSceneNiagaraSystemTrackImplementation");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneNiagaraSystemTrackImplementation()
		{
		}

		public static bool operator ==(FMovieSceneNiagaraSystemTrackImplementation A, FMovieSceneNiagaraSystemTrackImplementation B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneNiagaraSystemTrackImplementation A, FMovieSceneNiagaraSystemTrackImplementation B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneNiagaraSystemTrackImplementation;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFrameNumber SpawnSectionStartFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnSectionStartFrame, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnSectionStartFrame, __InBuffer);
				}
			}
		}

		public FFrameNumber SpawnSectionEndFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnSectionEndFrame, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnSectionEndFrame, __InBuffer);
				}
			}
		}

		public ENiagaraSystemSpawnSectionStartBehavior SpawnSectionStartBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnSectionStartBehavior, __ReturnBuffer);

					return *(ENiagaraSystemSpawnSectionStartBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnSectionStartBehavior, __InBuffer);
				}
			}
		}

		public ENiagaraSystemSpawnSectionEvaluateBehavior SpawnSectionEvaluateBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnSectionEvaluateBehavior, __ReturnBuffer);

					return *(ENiagaraSystemSpawnSectionEvaluateBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnSectionEvaluateBehavior, __InBuffer);
				}
			}
		}

		public ENiagaraSystemSpawnSectionEndBehavior SpawnSectionEndBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnSectionEndBehavior, __ReturnBuffer);

					return *(ENiagaraSystemSpawnSectionEndBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnSectionEndBehavior, __InBuffer);
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

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AgeUpdateMode, __ReturnBuffer);

					return *(ENiagaraAgeUpdateMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AgeUpdateMode, __InBuffer);
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

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowScalability, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowScalability, __InBuffer);
				}
			}
		}

		private static uint __SpawnSectionStartFrame = 0;

		private static uint __SpawnSectionEndFrame = 0;

		private static uint __SpawnSectionStartBehavior = 0;

		private static uint __SpawnSectionEvaluateBehavior = 0;

		private static uint __SpawnSectionEndBehavior = 0;

		private static uint __AgeUpdateMode = 0;

		private static uint __bAllowScalability = 0;

	}
}