﻿using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings")]
	public partial class FChaosBreakingEventRequestSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FChaosBreakingEventRequestSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FChaosBreakingEventRequestSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FChaosBreakingEventRequestSettings A, FChaosBreakingEventRequestSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FChaosBreakingEventRequestSettings A, FChaosBreakingEventRequestSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FChaosBreakingEventRequestSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int MaxNumberOfResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxNumberOfResults, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxNumberOfResults, __InBuffer);
				}
			}
		}

		public float MinRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinRadius, __InBuffer);
				}
			}
		}

		public float MinSpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinSpeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinSpeed, __InBuffer);
				}
			}
		}

		public float MinMass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinMass, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinMass, __InBuffer);
				}
			}
		}

		public float MaxDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxDistance, __InBuffer);
				}
			}
		}

		public EChaosBreakingSortMethod SortMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SortMethod, __ReturnBuffer);

					return *(EChaosBreakingSortMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SortMethod, __InBuffer);
				}
			}
		}

		private static uint __MaxNumberOfResults = 0;

		private static uint __MinRadius = 0;

		private static uint __MinSpeed = 0;

		private static uint __MinMass = 0;

		private static uint __MaxDistance = 0;

		private static uint __SortMethod = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}