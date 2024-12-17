using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISenseAffiliationFilter")]
	public partial class FAISenseAffiliationFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.AISenseAffiliationFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAISenseAffiliationFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAISenseAffiliationFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAISenseAffiliationFilter A, FAISenseAffiliationFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAISenseAffiliationFilter A, FAISenseAffiliationFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAISenseAffiliationFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bDetectEnemies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDetectEnemies, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDetectEnemies, __InBuffer);
				}
			}
		}

		public bool bDetectNeutrals
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDetectNeutrals, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDetectNeutrals, __InBuffer);
				}
			}
		}

		public bool bDetectFriendlies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDetectFriendlies, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDetectFriendlies, __InBuffer);
				}
			}
		}

		private static uint __bDetectEnemies = 0;

		private static uint __bDetectNeutrals = 0;

		private static uint __bDetectFriendlies = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}