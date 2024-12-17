using Script.CoreUObject;
using Script.Library;
using Script.InteractiveToolsFramework;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.ActiveEditorGizmo")]
	public partial class FActiveEditorGizmo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorInteractiveToolsFramework.ActiveEditorGizmo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActiveEditorGizmo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActiveEditorGizmo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActiveEditorGizmo A, FActiveEditorGizmo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActiveEditorGizmo A, FActiveEditorGizmo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActiveEditorGizmo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UInteractiveGizmo Gizmo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Gizmo, __ReturnBuffer);

					return *(UInteractiveGizmo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Gizmo, __InBuffer);
				}
			}
		}

		private static uint __Gizmo = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}