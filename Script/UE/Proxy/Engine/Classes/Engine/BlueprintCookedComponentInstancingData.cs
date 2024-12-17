using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintCookedComponentInstancingData")]
	public partial class FBlueprintCookedComponentInstancingData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BlueprintCookedComponentInstancingData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintCookedComponentInstancingData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBlueprintCookedComponentInstancingData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBlueprintCookedComponentInstancingData A, FBlueprintCookedComponentInstancingData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintCookedComponentInstancingData A, FBlueprintCookedComponentInstancingData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintCookedComponentInstancingData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FBlueprintComponentChangedPropertyInfo> ChangedPropertyList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChangedPropertyList, __ReturnBuffer);

					return *(TArray<FBlueprintComponentChangedPropertyInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChangedPropertyList, __InBuffer);
				}
			}
		}

		public bool bHasValidCookedData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHasValidCookedData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHasValidCookedData, __InBuffer);
				}
			}
		}

		private static uint __ChangedPropertyList = 0;

		private static uint __bHasValidCookedData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}