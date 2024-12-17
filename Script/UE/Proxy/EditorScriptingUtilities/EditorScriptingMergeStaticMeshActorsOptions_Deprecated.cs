using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EditorScriptingMergeStaticMeshActorsOptions_Deprecated")]
	public partial class FEditorScriptingMergeStaticMeshActorsOptions_Deprecated : FEditorScriptingJoinStaticMeshActorsOptions_Deprecated, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorScriptingUtilities.EditorScriptingMergeStaticMeshActorsOptions_Deprecated");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorScriptingMergeStaticMeshActorsOptions_Deprecated()
		{
		}

		public static bool operator ==(FEditorScriptingMergeStaticMeshActorsOptions_Deprecated A, FEditorScriptingMergeStaticMeshActorsOptions_Deprecated B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorScriptingMergeStaticMeshActorsOptions_Deprecated A, FEditorScriptingMergeStaticMeshActorsOptions_Deprecated B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorScriptingMergeStaticMeshActorsOptions_Deprecated;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bSpawnMergedActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSpawnMergedActor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSpawnMergedActor, __InBuffer);
				}
			}
		}

		public FString BasePackageName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BasePackageName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BasePackageName, __InBuffer);
				}
			}
		}

		public FMeshMergingSettings MeshMergingSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeshMergingSettings, __ReturnBuffer);

					return *(FMeshMergingSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeshMergingSettings, __InBuffer);
				}
			}
		}

		private static uint __bSpawnMergedActor = 0;

		private static uint __BasePackageName = 0;

		private static uint __MeshMergingSettings = 0;

	}
}