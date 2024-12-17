using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ComponentOverrideRecord")]
	public partial class FComponentOverrideRecord : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ComponentOverrideRecord");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FComponentOverrideRecord() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FComponentOverrideRecord() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FComponentOverrideRecord A, FComponentOverrideRecord B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FComponentOverrideRecord A, FComponentOverrideRecord B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FComponentOverrideRecord;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UObject> ComponentClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentClass, __InBuffer);
				}
			}
		}

		public UActorComponent ComponentTemplate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentTemplate, __ReturnBuffer);

					return *(UActorComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentTemplate, __InBuffer);
				}
			}
		}

		public FComponentKey ComponentKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentKey, __ReturnBuffer);

					return *(FComponentKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentKey, __InBuffer);
				}
			}
		}

		public FBlueprintCookedComponentInstancingData CookedComponentInstancingData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CookedComponentInstancingData, __ReturnBuffer);

					return *(FBlueprintCookedComponentInstancingData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CookedComponentInstancingData, __InBuffer);
				}
			}
		}

		private static uint __ComponentClass = 0;

		private static uint __ComponentTemplate = 0;

		private static uint __ComponentKey = 0;

		private static uint __CookedComponentInstancingData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}