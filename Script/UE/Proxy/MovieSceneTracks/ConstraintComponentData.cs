using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.ConstraintComponentData")]
	public partial class FConstraintComponentData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.ConstraintComponentData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FConstraintComponentData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FConstraintComponentData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FConstraintComponentData A, FConstraintComponentData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FConstraintComponentData A, FConstraintComponentData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FConstraintComponentData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ConstraintName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConstraintName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConstraintName, __InBuffer);
				}
			}
		}

		private static uint __ConstraintName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}