using Script.CoreUObject;
using Script.Library;
using Script.SequencerScripting;

namespace Script.LevelSequenceEditor
{
	[PathName("/Script/LevelSequenceEditor.MovieSceneScriptingParams")]
	public partial class FMovieSceneScriptingParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LevelSequenceEditor.MovieSceneScriptingParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneScriptingParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneScriptingParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneScriptingParams A, FMovieSceneScriptingParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneScriptingParams A, FMovieSceneScriptingParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneScriptingParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ESequenceTimeUnit TimeUnit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TimeUnit, __ReturnBuffer);

					return *(ESequenceTimeUnit*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TimeUnit, __InBuffer);
				}
			}
		}

		private static uint __TimeUnit = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}