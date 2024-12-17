using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ImportMeshLodSectionsData")]
	public partial class FImportMeshLodSectionsData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.ImportMeshLodSectionsData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FImportMeshLodSectionsData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FImportMeshLodSectionsData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FImportMeshLodSectionsData A, FImportMeshLodSectionsData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FImportMeshLodSectionsData A, FImportMeshLodSectionsData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FImportMeshLodSectionsData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> SectionOriginalMaterialName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SectionOriginalMaterialName, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SectionOriginalMaterialName, __InBuffer);
				}
			}
		}

		private static uint __SectionOriginalMaterialName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}