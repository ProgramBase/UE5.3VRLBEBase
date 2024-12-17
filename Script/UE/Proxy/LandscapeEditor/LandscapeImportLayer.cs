using Script.CoreUObject;
using Script.Library;
using Script.Landscape;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.LandscapeImportLayer")]
	public partial class FLandscapeImportLayer : FLandscapeImportLayerInfo, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LandscapeEditor.LandscapeImportLayer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLandscapeImportLayer()
		{
		}

		public static bool operator ==(FLandscapeImportLayer A, FLandscapeImportLayer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLandscapeImportLayer A, FLandscapeImportLayer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLandscapeImportLayer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ULandscapeMaterialInstanceConstant ThumbnailMIC
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ThumbnailMIC, __ReturnBuffer);

					return *(ULandscapeMaterialInstanceConstant*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ThumbnailMIC, __InBuffer);
				}
			}
		}

		public ELandscapeImportResult ImportResult
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImportResult, __ReturnBuffer);

					return *(ELandscapeImportResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImportResult, __InBuffer);
				}
			}
		}

		public FText ErrorMessage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ErrorMessage, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ErrorMessage, __InBuffer);
				}
			}
		}

		public FString ExportFilePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExportFilePath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExportFilePath, __InBuffer);
				}
			}
		}

		public bool bSelected
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSelected, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSelected, __InBuffer);
				}
			}
		}

		private static uint __ThumbnailMIC = 0;

		private static uint __ImportResult = 0;

		private static uint __ErrorMessage = 0;

		private static uint __ExportFilePath = 0;

		private static uint __bSelected = 0;

	}
}