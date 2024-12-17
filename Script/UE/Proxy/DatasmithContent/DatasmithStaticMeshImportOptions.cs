using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithStaticMeshImportOptions")]
	public partial class FDatasmithStaticMeshImportOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DatasmithContent.DatasmithStaticMeshImportOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDatasmithStaticMeshImportOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDatasmithStaticMeshImportOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDatasmithStaticMeshImportOptions A, FDatasmithStaticMeshImportOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDatasmithStaticMeshImportOptions A, FDatasmithStaticMeshImportOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDatasmithStaticMeshImportOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EDatasmithImportLightmapMin MinLightmapResolution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinLightmapResolution, __ReturnBuffer);

					return *(EDatasmithImportLightmapMin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinLightmapResolution, __InBuffer);
				}
			}
		}

		public EDatasmithImportLightmapMax MaxLightmapResolution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxLightmapResolution, __ReturnBuffer);

					return *(EDatasmithImportLightmapMax*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxLightmapResolution, __InBuffer);
				}
			}
		}

		public bool bGenerateLightmapUVs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bGenerateLightmapUVs, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bGenerateLightmapUVs, __InBuffer);
				}
			}
		}

		public bool bRemoveDegenerates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRemoveDegenerates, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRemoveDegenerates, __InBuffer);
				}
			}
		}

		private static uint __MinLightmapResolution = 0;

		private static uint __MaxLightmapResolution = 0;

		private static uint __bGenerateLightmapUVs = 0;

		private static uint __bRemoveDegenerates = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}