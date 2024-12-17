using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InstanceCacheDataBase")]
	public partial class FInstanceCacheDataBase : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.InstanceCacheDataBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInstanceCacheDataBase() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInstanceCacheDataBase() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInstanceCacheDataBase A, FInstanceCacheDataBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInstanceCacheDataBase A, FInstanceCacheDataBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInstanceCacheDataBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<byte> SavedProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SavedProperties, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SavedProperties, __InBuffer);
				}
			}
		}

		public FDataCacheDuplicatedObjectData UniqueTransientPackage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UniqueTransientPackage, __ReturnBuffer);

					return *(FDataCacheDuplicatedObjectData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UniqueTransientPackage, __InBuffer);
				}
			}
		}

		public TArray<FDataCacheDuplicatedObjectData> DuplicatedObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DuplicatedObjects, __ReturnBuffer);

					return *(TArray<FDataCacheDuplicatedObjectData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DuplicatedObjects, __InBuffer);
				}
			}
		}

		public TArray<UObject> ReferencedObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReferencedObjects, __ReturnBuffer);

					return *(TArray<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReferencedObjects, __InBuffer);
				}
			}
		}

		public TArray<FName> ReferencedNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReferencedNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReferencedNames, __InBuffer);
				}
			}
		}

		private static uint __SavedProperties = 0;

		private static uint __UniqueTransientPackage = 0;

		private static uint __DuplicatedObjects = 0;

		private static uint __ReferencedObjects = 0;

		private static uint __ReferencedNames = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}