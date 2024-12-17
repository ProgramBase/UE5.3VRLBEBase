using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MeshBudgetProjectSettings")]
	public partial class UMeshBudgetProjectSettings : UDeveloperSettings, IStaticClass
	{
		public bool bEnableStaticMeshBudget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableStaticMeshBudget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableStaticMeshBudget, __InBuffer);
				}
			}
		}

		public TArray<FStaticMeshBudgetInfo> StaticMeshBudgetInfos
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshBudgetInfos, __ReturnBuffer);

					return *(TArray<FStaticMeshBudgetInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshBudgetInfos, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MeshBudgetProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bEnableStaticMeshBudget = 0;

		private static uint __StaticMeshBudgetInfos = 0;
	}
}