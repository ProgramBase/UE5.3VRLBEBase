using Script.CoreUObject;
using Script.Library;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.FoliageTypeObject")]
	public partial class FFoliageTypeObject : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Foliage.FoliageTypeObject");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFoliageTypeObject() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFoliageTypeObject() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFoliageTypeObject A, FFoliageTypeObject B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFoliageTypeObject A, FFoliageTypeObject B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFoliageTypeObject;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UObject FoliageTypeObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FoliageTypeObject, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FoliageTypeObject, __InBuffer);
				}
			}
		}

		public UFoliageType TypeInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TypeInstance, __ReturnBuffer);

					return *(UFoliageType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TypeInstance, __InBuffer);
				}
			}
		}

		public bool bIsAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsAsset, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsAsset, __InBuffer);
				}
			}
		}

		private static uint __FoliageTypeObject = 0;

		private static uint __TypeInstance = 0;

		private static uint __bIsAsset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}