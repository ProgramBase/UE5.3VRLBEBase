using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoElementMeshRenderStateAttributes")]
	public partial class FGizmoElementMeshRenderStateAttributes : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InteractiveToolsFramework.GizmoElementMeshRenderStateAttributes");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGizmoElementMeshRenderStateAttributes() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGizmoElementMeshRenderStateAttributes() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGizmoElementMeshRenderStateAttributes A, FGizmoElementMeshRenderStateAttributes B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGizmoElementMeshRenderStateAttributes A, FGizmoElementMeshRenderStateAttributes B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGizmoElementMeshRenderStateAttributes;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGizmoElementMaterialAttribute Material
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Material, __ReturnBuffer);

					return *(FGizmoElementMaterialAttribute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Material, __InBuffer);
				}
			}
		}

		public FGizmoElementMaterialAttribute HoverMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HoverMaterial, __ReturnBuffer);

					return *(FGizmoElementMaterialAttribute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HoverMaterial, __InBuffer);
				}
			}
		}

		public FGizmoElementMaterialAttribute InteractMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InteractMaterial, __ReturnBuffer);

					return *(FGizmoElementMaterialAttribute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InteractMaterial, __InBuffer);
				}
			}
		}

		public FGizmoElementColorAttribute VertexColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VertexColor, __ReturnBuffer);

					return *(FGizmoElementColorAttribute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VertexColor, __InBuffer);
				}
			}
		}

		public FGizmoElementColorAttribute HoverVertexColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HoverVertexColor, __ReturnBuffer);

					return *(FGizmoElementColorAttribute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HoverVertexColor, __InBuffer);
				}
			}
		}

		public FGizmoElementColorAttribute InteractVertexColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InteractVertexColor, __ReturnBuffer);

					return *(FGizmoElementColorAttribute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InteractVertexColor, __InBuffer);
				}
			}
		}

		private static uint __Material = 0;

		private static uint __HoverMaterial = 0;

		private static uint __InteractMaterial = 0;

		private static uint __VertexColor = 0;

		private static uint __HoverVertexColor = 0;

		private static uint __InteractVertexColor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}