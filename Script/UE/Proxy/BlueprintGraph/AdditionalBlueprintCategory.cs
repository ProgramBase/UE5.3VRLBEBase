using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.AdditionalBlueprintCategory")]
	public partial class FAdditionalBlueprintCategory : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.AdditionalBlueprintCategory");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAdditionalBlueprintCategory() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAdditionalBlueprintCategory() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAdditionalBlueprintCategory A, FAdditionalBlueprintCategory B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAdditionalBlueprintCategory A, FAdditionalBlueprintCategory B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAdditionalBlueprintCategory;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FText Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Name, __InBuffer);
				}
			}
		}

		public FSoftClassPath ClassFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ClassFilter, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ClassFilter, __InBuffer);
				}
			}
		}

		private static uint __Name = 0;

		private static uint __ClassFilter = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}