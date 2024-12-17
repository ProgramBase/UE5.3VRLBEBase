using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.RandomStream")]
	public partial class FRandomStream : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.RandomStream");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRandomStream() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRandomStream() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRandomStream A, FRandomStream B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRandomStream A, FRandomStream B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRandomStream;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int InitialSeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InitialSeed, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InitialSeed, __InBuffer);
				}
			}
		}

		public int Seed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Seed, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Seed, __InBuffer);
				}
			}
		}

		private static uint __InitialSeed = 0;

		private static uint __Seed = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}