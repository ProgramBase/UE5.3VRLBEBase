using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StructCookedMetaDataStore")]
	public partial class FStructCookedMetaDataStore : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StructCookedMetaDataStore");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStructCookedMetaDataStore() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStructCookedMetaDataStore() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStructCookedMetaDataStore A, FStructCookedMetaDataStore B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStructCookedMetaDataStore A, FStructCookedMetaDataStore B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStructCookedMetaDataStore;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FObjectCookedMetaDataStore ObjectMetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectMetaData, __ReturnBuffer);

					return *(FObjectCookedMetaDataStore*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectMetaData, __InBuffer);
				}
			}
		}

		public TMap<FName, FFieldCookedMetaDataStore> PropertiesMetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertiesMetaData, __ReturnBuffer);

					return *(TMap<FName, FFieldCookedMetaDataStore>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertiesMetaData, __InBuffer);
				}
			}
		}

		private static uint __ObjectMetaData = 0;

		private static uint __PropertiesMetaData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}