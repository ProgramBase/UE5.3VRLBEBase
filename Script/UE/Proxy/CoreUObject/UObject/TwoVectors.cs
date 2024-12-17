using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.TwoVectors")]
	public partial class FTwoVectors : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.TwoVectors");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTwoVectors() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTwoVectors() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTwoVectors A, FTwoVectors B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTwoVectors A, FTwoVectors B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTwoVectors;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector v1
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __v1, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __v1, __InBuffer);
				}
			}
		}

		public FVector v2
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __v2, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __v2, __InBuffer);
				}
			}
		}

		private static uint __v1 = 0;

		private static uint __v2 = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}