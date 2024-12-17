using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosCloth
{
	[PathName("/Script/ChaosCloth.ChaosClothWeightedValue")]
	public partial class FChaosClothWeightedValue : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosCloth.ChaosClothWeightedValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FChaosClothWeightedValue() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FChaosClothWeightedValue() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FChaosClothWeightedValue A, FChaosClothWeightedValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FChaosClothWeightedValue A, FChaosClothWeightedValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FChaosClothWeightedValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Low
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Low, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Low, __InBuffer);
				}
			}
		}

		public float High
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __High, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __High, __InBuffer);
				}
			}
		}

		private static uint __Low = 0;

		private static uint __High = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}