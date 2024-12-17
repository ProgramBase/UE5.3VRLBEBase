using Script.CoreUObject;
using Script.Library;
using Script.InteractiveToolsFramework;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.TransformMeshesTarget")]
	public partial class FTransformMeshesTarget : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshModelingToolsExp.TransformMeshesTarget");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTransformMeshesTarget() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTransformMeshesTarget() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTransformMeshesTarget A, FTransformMeshesTarget B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTransformMeshesTarget A, FTransformMeshesTarget B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTransformMeshesTarget;

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