using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialEditorPromotionSettings")]
	public partial class FMaterialEditorPromotionSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MaterialEditorPromotionSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialEditorPromotionSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialEditorPromotionSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialEditorPromotionSettings A, FMaterialEditorPromotionSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialEditorPromotionSettings A, FMaterialEditorPromotionSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialEditorPromotionSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFilePath DefaultMaterialAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultMaterialAsset, __ReturnBuffer);

					return *(FFilePath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultMaterialAsset, __InBuffer);
				}
			}
		}

		public FFilePath DefaultDiffuseTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultDiffuseTexture, __ReturnBuffer);

					return *(FFilePath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultDiffuseTexture, __InBuffer);
				}
			}
		}

		public FFilePath DefaultNormalTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultNormalTexture, __ReturnBuffer);

					return *(FFilePath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultNormalTexture, __InBuffer);
				}
			}
		}

		private static uint __DefaultMaterialAsset = 0;

		private static uint __DefaultDiffuseTexture = 0;

		private static uint __DefaultNormalTexture = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}