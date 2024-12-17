using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.MovieScene2DTransformMask")]
	public partial class FMovieScene2DTransformMask : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.MovieScene2DTransformMask");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieScene2DTransformMask() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieScene2DTransformMask() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieScene2DTransformMask A, FMovieScene2DTransformMask B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieScene2DTransformMask A, FMovieScene2DTransformMask B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieScene2DTransformMask;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint Mask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Mask, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Mask, __InBuffer);
				}
			}
		}

		private static uint __Mask = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}