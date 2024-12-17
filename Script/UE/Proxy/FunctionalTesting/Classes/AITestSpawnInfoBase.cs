using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.AITestSpawnInfoBase")]
	public partial class FAITestSpawnInfoBase : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FunctionalTesting.AITestSpawnInfoBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAITestSpawnInfoBase() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAITestSpawnInfoBase() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAITestSpawnInfoBase A, FAITestSpawnInfoBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAITestSpawnInfoBase A, FAITestSpawnInfoBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAITestSpawnInfoBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public AActor SpawnLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnLocation, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnLocation, __InBuffer);
				}
			}
		}

		public int NumberToSpawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumberToSpawn, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumberToSpawn, __InBuffer);
				}
			}
		}

		public float SpawnDelay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnDelay, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnDelay, __InBuffer);
				}
			}
		}

		public float PreSpawnDelay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PreSpawnDelay, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PreSpawnDelay, __InBuffer);
				}
			}
		}

		private static uint __SpawnLocation = 0;

		private static uint __NumberToSpawn = 0;

		private static uint __SpawnDelay = 0;

		private static uint __PreSpawnDelay = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}