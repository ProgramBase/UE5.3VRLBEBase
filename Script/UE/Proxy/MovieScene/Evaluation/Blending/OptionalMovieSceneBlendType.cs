using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.OptionalMovieSceneBlendType")]
	public partial class FOptionalMovieSceneBlendType : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.OptionalMovieSceneBlendType");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FOptionalMovieSceneBlendType() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FOptionalMovieSceneBlendType() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FOptionalMovieSceneBlendType A, FOptionalMovieSceneBlendType B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FOptionalMovieSceneBlendType A, FOptionalMovieSceneBlendType B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FOptionalMovieSceneBlendType;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EMovieSceneBlendType BlendType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlendType, __ReturnBuffer);

					return *(EMovieSceneBlendType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlendType, __InBuffer);
				}
			}
		}

		public bool bIsValid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsValid, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsValid, __InBuffer);
				}
			}
		}

		private static uint __BlendType = 0;

		private static uint __bIsValid = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}