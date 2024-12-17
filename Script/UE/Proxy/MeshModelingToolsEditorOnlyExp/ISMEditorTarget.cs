using Script.CoreUObject;
using Script.Library;
using Script.InteractiveToolsFramework;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.ISMEditorTarget")]
	public partial class FISMEditorTarget : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshModelingToolsEditorOnlyExp.ISMEditorTarget");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FISMEditorTarget() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FISMEditorTarget() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FISMEditorTarget A, FISMEditorTarget B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FISMEditorTarget A, FISMEditorTarget B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FISMEditorTarget;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UTransformProxy TransformProxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TransformProxy, __ReturnBuffer);

					return *(UTransformProxy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TransformProxy, __InBuffer);
				}
			}
		}

		public UCombinedTransformGizmo TransformGizmo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TransformGizmo, __ReturnBuffer);

					return *(UCombinedTransformGizmo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TransformGizmo, __InBuffer);
				}
			}
		}

		private static uint __TransformProxy = 0;

		private static uint __TransformGizmo = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}