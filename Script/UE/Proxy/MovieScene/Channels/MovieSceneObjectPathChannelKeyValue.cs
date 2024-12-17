using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneObjectPathChannelKeyValue")]
	public partial class FMovieSceneObjectPathChannelKeyValue : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneObjectPathChannelKeyValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneObjectPathChannelKeyValue() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneObjectPathChannelKeyValue() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneObjectPathChannelKeyValue A, FMovieSceneObjectPathChannelKeyValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneObjectPathChannelKeyValue A, FMovieSceneObjectPathChannelKeyValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneObjectPathChannelKeyValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSoftObjectPtr<UObject> SoftPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SoftPtr, __ReturnBuffer);

					return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SoftPtr, __InBuffer);
				}
			}
		}

		public UObject HardPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HardPtr, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HardPtr, __InBuffer);
				}
			}
		}

		private static uint __SoftPtr = 0;

		private static uint __HardPtr = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}