using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.MovieSceneControlRigSpaceBaseKey")]
	public partial class FMovieSceneControlRigSpaceBaseKey : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.MovieSceneControlRigSpaceBaseKey");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneControlRigSpaceBaseKey() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneControlRigSpaceBaseKey() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneControlRigSpaceBaseKey A, FMovieSceneControlRigSpaceBaseKey B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneControlRigSpaceBaseKey A, FMovieSceneControlRigSpaceBaseKey B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneControlRigSpaceBaseKey;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EMovieSceneControlRigSpaceType SpaceType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpaceType, __ReturnBuffer);

					return *(EMovieSceneControlRigSpaceType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpaceType, __InBuffer);
				}
			}
		}

		public FRigElementKey ControlRigElement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControlRigElement, __ReturnBuffer);

					return *(FRigElementKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControlRigElement, __InBuffer);
				}
			}
		}

		private static uint __SpaceType = 0;

		private static uint __ControlRigElement = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}