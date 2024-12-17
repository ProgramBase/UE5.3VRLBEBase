using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTools
{
	[PathName("/Script/MovieSceneTools.MovieSceneToolsFbxSettings")]
	public partial class FMovieSceneToolsFbxSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTools.MovieSceneToolsFbxSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneToolsFbxSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneToolsFbxSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneToolsFbxSettings A, FMovieSceneToolsFbxSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneToolsFbxSettings A, FMovieSceneToolsFbxSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneToolsFbxSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString FbxPropertyName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FbxPropertyName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FbxPropertyName, __InBuffer);
				}
			}
		}

		public FMovieSceneToolsPropertyTrackSettings PropertyPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyPath, __ReturnBuffer);

					return *(FMovieSceneToolsPropertyTrackSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyPath, __InBuffer);
				}
			}
		}

		public EMovieSceneToolsPropertyTrackType PropertyType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyType, __ReturnBuffer);

					return *(EMovieSceneToolsPropertyTrackType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyType, __InBuffer);
				}
			}
		}

		private static uint __FbxPropertyName = 0;

		private static uint __PropertyPath = 0;

		private static uint __PropertyType = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}