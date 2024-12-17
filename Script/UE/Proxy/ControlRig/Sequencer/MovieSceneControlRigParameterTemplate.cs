using Script.CoreUObject;
using Script.Library;
using Script.MovieSceneTracks;
using Script.Constraints;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.MovieSceneControlRigParameterTemplate")]
	public partial class FMovieSceneControlRigParameterTemplate : FMovieSceneParameterSectionTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.MovieSceneControlRigParameterTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneControlRigParameterTemplate()
		{
		}

		public static bool operator ==(FMovieSceneControlRigParameterTemplate A, FMovieSceneControlRigParameterTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneControlRigParameterTemplate A, FMovieSceneControlRigParameterTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneControlRigParameterTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FEnumParameterNameAndCurve> Enums
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Enums, __ReturnBuffer);

					return *(TArray<FEnumParameterNameAndCurve>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Enums, __InBuffer);
				}
			}
		}

		public TArray<FIntegerParameterNameAndCurve> Integers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Integers, __ReturnBuffer);

					return *(TArray<FIntegerParameterNameAndCurve>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Integers, __InBuffer);
				}
			}
		}

		public TArray<FSpaceControlNameAndChannel> Spaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Spaces, __ReturnBuffer);

					return *(TArray<FSpaceControlNameAndChannel>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Spaces, __InBuffer);
				}
			}
		}

		public TArray<FConstraintAndActiveChannel> Constraints
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Constraints, __ReturnBuffer);

					return *(TArray<FConstraintAndActiveChannel>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Constraints, __InBuffer);
				}
			}
		}

		private static uint __Enums = 0;

		private static uint __Integers = 0;

		private static uint __Spaces = 0;

		private static uint __Constraints = 0;

	}
}