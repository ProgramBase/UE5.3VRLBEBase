using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.FieldCookedMetaDataStore")]
	public partial class FFieldCookedMetaDataStore : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.FieldCookedMetaDataStore");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFieldCookedMetaDataStore() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFieldCookedMetaDataStore() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFieldCookedMetaDataStore A, FFieldCookedMetaDataStore B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFieldCookedMetaDataStore A, FFieldCookedMetaDataStore B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFieldCookedMetaDataStore;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FName, FString> FieldMetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FieldMetaData, __ReturnBuffer);

					return *(TMap<FName, FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FieldMetaData, __InBuffer);
				}
			}
		}

		private static uint __FieldMetaData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}