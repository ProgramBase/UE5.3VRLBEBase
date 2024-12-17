using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BuildPromotionTestSettings")]
	public partial class FBuildPromotionTestSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BuildPromotionTestSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBuildPromotionTestSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBuildPromotionTestSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBuildPromotionTestSettings A, FBuildPromotionTestSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBuildPromotionTestSettings A, FBuildPromotionTestSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBuildPromotionTestSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFilePath DefaultStaticMeshAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultStaticMeshAsset, __ReturnBuffer);

					return *(FFilePath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultStaticMeshAsset, __InBuffer);
				}
			}
		}

		public FBuildPromotionImportWorkflowSettings ImportWorkflow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImportWorkflow, __ReturnBuffer);

					return *(FBuildPromotionImportWorkflowSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImportWorkflow, __InBuffer);
				}
			}
		}

		public FBuildPromotionOpenAssetSettings OpenAssets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OpenAssets, __ReturnBuffer);

					return *(FBuildPromotionOpenAssetSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OpenAssets, __InBuffer);
				}
			}
		}

		public FBuildPromotionNewProjectSettings NewProjectSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewProjectSettings, __ReturnBuffer);

					return *(FBuildPromotionNewProjectSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewProjectSettings, __InBuffer);
				}
			}
		}

		public FFilePath SourceControlMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceControlMaterial, __ReturnBuffer);

					return *(FFilePath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceControlMaterial, __InBuffer);
				}
			}
		}

		private static uint __DefaultStaticMeshAsset = 0;

		private static uint __ImportWorkflow = 0;

		private static uint __OpenAssets = 0;

		private static uint __NewProjectSettings = 0;

		private static uint __SourceControlMaterial = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}