using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TestSparseClassDataStorage")]
	public partial class FTestSparseClassDataStorage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.TestSparseClassDataStorage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTestSparseClassDataStorage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTestSparseClassDataStorage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTestSparseClassDataStorage A, FTestSparseClassDataStorage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTestSparseClassDataStorage A, FTestSparseClassDataStorage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTestSparseClassDataStorage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<int, int> Map
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Map, __ReturnBuffer);

					return *(TMap<int, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Map, __InBuffer);
				}
			}
		}

		private static uint __Map = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}