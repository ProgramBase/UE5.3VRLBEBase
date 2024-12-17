using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BuildPromotionNewProjectSettings")]
	public partial class FBuildPromotionNewProjectSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BuildPromotionNewProjectSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBuildPromotionNewProjectSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBuildPromotionNewProjectSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBuildPromotionNewProjectSettings A, FBuildPromotionNewProjectSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBuildPromotionNewProjectSettings A, FBuildPromotionNewProjectSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBuildPromotionNewProjectSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDirectoryPath NewProjectFolderOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewProjectFolderOverride, __ReturnBuffer);

					return *(FDirectoryPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewProjectFolderOverride, __InBuffer);
				}
			}
		}

		public FString NewProjectNameOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewProjectNameOverride, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewProjectNameOverride, __InBuffer);
				}
			}
		}

		private static uint __NewProjectFolderOverride = 0;

		private static uint __NewProjectNameOverride = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}