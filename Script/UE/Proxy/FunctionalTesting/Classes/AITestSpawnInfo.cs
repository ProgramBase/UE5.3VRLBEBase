using Script.CoreUObject;
using Script.Library;
using Script.Engine;
using Script.AIModule;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.AITestSpawnInfo")]
	public partial class FAITestSpawnInfo : FAITestSpawnInfoBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FunctionalTesting.AITestSpawnInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAITestSpawnInfo()
		{
		}

		public static bool operator ==(FAITestSpawnInfo A, FAITestSpawnInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAITestSpawnInfo A, FAITestSpawnInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAITestSpawnInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<APawn> PawnClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PawnClass, __ReturnBuffer);

					return *(TSubclassOf<APawn>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PawnClass, __InBuffer);
				}
			}
		}

		public TSubclassOf<AAIController> ControllerClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControllerClass, __ReturnBuffer);

					return *(TSubclassOf<AAIController>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControllerClass, __InBuffer);
				}
			}
		}

		public FGenericTeamId TeamID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TeamID, __ReturnBuffer);

					return *(FGenericTeamId*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TeamID, __InBuffer);
				}
			}
		}

		public UBehaviorTree BehaviorTree
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BehaviorTree, __ReturnBuffer);

					return *(UBehaviorTree*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BehaviorTree, __InBuffer);
				}
			}
		}

		private static uint __PawnClass = 0;

		private static uint __ControllerClass = 0;

		private static uint __TeamID = 0;

		private static uint __BehaviorTree = 0;

	}
}