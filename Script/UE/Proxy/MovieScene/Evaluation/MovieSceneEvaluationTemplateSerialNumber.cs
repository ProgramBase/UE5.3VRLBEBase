using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvaluationTemplateSerialNumber")]
	public partial class FMovieSceneEvaluationTemplateSerialNumber : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvaluationTemplateSerialNumber");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvaluationTemplateSerialNumber() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvaluationTemplateSerialNumber() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvaluationTemplateSerialNumber A, FMovieSceneEvaluationTemplateSerialNumber B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvaluationTemplateSerialNumber A, FMovieSceneEvaluationTemplateSerialNumber B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvaluationTemplateSerialNumber;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}