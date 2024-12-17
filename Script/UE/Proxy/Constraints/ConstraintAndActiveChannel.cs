using Script.CoreUObject;
using Script.Library;

namespace Script.Constraints
{
	[PathName("/Script/Constraints.ConstraintAndActiveChannel")]
	public partial class FConstraintAndActiveChannel : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Constraints.ConstraintAndActiveChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FConstraintAndActiveChannel() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FConstraintAndActiveChannel() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FConstraintAndActiveChannel A, FConstraintAndActiveChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FConstraintAndActiveChannel A, FConstraintAndActiveChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FConstraintAndActiveChannel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSoftObjectPtr<UTickableConstraint> Constraint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Constraint, __ReturnBuffer);

					return *(TSoftObjectPtr<UTickableConstraint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Constraint, __InBuffer);
				}
			}
		}

		public FMovieSceneConstraintChannel ActiveChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActiveChannel, __ReturnBuffer);

					return *(FMovieSceneConstraintChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActiveChannel, __InBuffer);
				}
			}
		}

		public UTickableConstraint ConstraintCopyToSpawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConstraintCopyToSpawn, __ReturnBuffer);

					return *(UTickableConstraint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConstraintCopyToSpawn, __InBuffer);
				}
			}
		}

		private static uint __Constraint = 0;

		private static uint __ActiveChannel = 0;

		private static uint __ConstraintCopyToSpawn = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}