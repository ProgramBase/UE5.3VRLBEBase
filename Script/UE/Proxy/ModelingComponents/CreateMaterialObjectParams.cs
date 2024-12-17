using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.CreateMaterialObjectParams")]
	public partial class FCreateMaterialObjectParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ModelingComponents.CreateMaterialObjectParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCreateMaterialObjectParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCreateMaterialObjectParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCreateMaterialObjectParams A, FCreateMaterialObjectParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCreateMaterialObjectParams A, FCreateMaterialObjectParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCreateMaterialObjectParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UWorld TargetWorld
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetWorld, __ReturnBuffer);

					return *(UWorld*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetWorld, __InBuffer);
				}
			}
		}

		public UObject StoreRelativeToObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StoreRelativeToObject, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StoreRelativeToObject, __InBuffer);
				}
			}
		}

		public FString BaseName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BaseName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BaseName, __InBuffer);
				}
			}
		}

		public UMaterialInterface MaterialToDuplicate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaterialToDuplicate, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaterialToDuplicate, __InBuffer);
				}
			}
		}

		private static uint __TargetWorld = 0;

		private static uint __StoreRelativeToObject = 0;

		private static uint __BaseName = 0;

		private static uint __MaterialToDuplicate = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}