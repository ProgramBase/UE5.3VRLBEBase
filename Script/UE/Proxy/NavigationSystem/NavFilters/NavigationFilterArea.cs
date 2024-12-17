using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavigationFilterArea")]
	public partial class FNavigationFilterArea : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NavigationSystem.NavigationFilterArea");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNavigationFilterArea() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNavigationFilterArea() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNavigationFilterArea A, FNavigationFilterArea B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNavigationFilterArea A, FNavigationFilterArea B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNavigationFilterArea;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UNavArea> AreaClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AreaClass, __ReturnBuffer);

					return *(TSubclassOf<UNavArea>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AreaClass, __InBuffer);
				}
			}
		}

		public float TravelCostOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TravelCostOverride, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TravelCostOverride, __InBuffer);
				}
			}
		}

		public float EnteringCostOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EnteringCostOverride, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EnteringCostOverride, __InBuffer);
				}
			}
		}

		public bool bIsExcluded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsExcluded, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsExcluded, __InBuffer);
				}
			}
		}

		public bool bOverrideTravelCost
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideTravelCost, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideTravelCost, __InBuffer);
				}
			}
		}

		public bool bOverrideEnteringCost
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideEnteringCost, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideEnteringCost, __InBuffer);
				}
			}
		}

		private static uint __AreaClass = 0;

		private static uint __TravelCostOverride = 0;

		private static uint __EnteringCostOverride = 0;

		private static uint __bIsExcluded = 0;

		private static uint __bOverrideTravelCost = 0;

		private static uint __bOverrideEnteringCost = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}