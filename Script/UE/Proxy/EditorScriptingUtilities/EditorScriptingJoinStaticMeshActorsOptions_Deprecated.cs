using Script.CoreUObject;
using Script.Library;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EditorScriptingJoinStaticMeshActorsOptions_Deprecated")]
	public partial class FEditorScriptingJoinStaticMeshActorsOptions_Deprecated : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorScriptingUtilities.EditorScriptingJoinStaticMeshActorsOptions_Deprecated");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorScriptingJoinStaticMeshActorsOptions_Deprecated() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorScriptingJoinStaticMeshActorsOptions_Deprecated() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorScriptingJoinStaticMeshActorsOptions_Deprecated A, FEditorScriptingJoinStaticMeshActorsOptions_Deprecated B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorScriptingJoinStaticMeshActorsOptions_Deprecated A, FEditorScriptingJoinStaticMeshActorsOptions_Deprecated B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorScriptingJoinStaticMeshActorsOptions_Deprecated;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bDestroySourceActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDestroySourceActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDestroySourceActors, __InBuffer);
				}
			}
		}

		public FString NewActorLabel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewActorLabel, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewActorLabel, __InBuffer);
				}
			}
		}

		public bool bRenameComponentsFromSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRenameComponentsFromSource, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRenameComponentsFromSource, __InBuffer);
				}
			}
		}

		private static uint __bDestroySourceActors = 0;

		private static uint __NewActorLabel = 0;

		private static uint __bRenameComponentsFromSource = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}