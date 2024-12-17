using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WeightedBlendables")]
	public partial class FWeightedBlendables : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.WeightedBlendables");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWeightedBlendables() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWeightedBlendables() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWeightedBlendables A, FWeightedBlendables B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWeightedBlendables A, FWeightedBlendables B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWeightedBlendables;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FWeightedBlendable> Array
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Array, __ReturnBuffer);

					return *(TArray<FWeightedBlendable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Array, __InBuffer);
				}
			}
		}

		private static uint __Array = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}