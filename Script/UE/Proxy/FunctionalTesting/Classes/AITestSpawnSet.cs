using Script.CoreUObject;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.AITestSpawnSet")]
	public partial class FAITestSpawnSet : FAITestSpawnSetBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FunctionalTesting.AITestSpawnSet");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAITestSpawnSet()
		{
		}

		public static bool operator ==(FAITestSpawnSet A, FAITestSpawnSet B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAITestSpawnSet A, FAITestSpawnSet B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAITestSpawnSet;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FAITestSpawnInfo> SpawnInfoContainer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnInfoContainer, __ReturnBuffer);

					return *(TArray<FAITestSpawnInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnInfoContainer, __InBuffer);
				}
			}
		}

		private static uint __SpawnInfoContainer = 0;

	}
}