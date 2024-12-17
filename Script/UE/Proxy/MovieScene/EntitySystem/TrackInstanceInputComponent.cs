using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.TrackInstanceInputComponent")]
	public partial class FTrackInstanceInputComponent : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.TrackInstanceInputComponent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTrackInstanceInputComponent() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTrackInstanceInputComponent() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTrackInstanceInputComponent A, FTrackInstanceInputComponent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTrackInstanceInputComponent A, FTrackInstanceInputComponent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTrackInstanceInputComponent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMovieSceneSection Section
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Section, __ReturnBuffer);

					return *(UMovieSceneSection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Section, __InBuffer);
				}
			}
		}

		public int OutputIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OutputIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OutputIndex, __InBuffer);
				}
			}
		}

		private static uint __Section = 0;

		private static uint __OutputIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}