using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoElementLineRenderStateAttributes")]
	public partial class FGizmoElementLineRenderStateAttributes : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InteractiveToolsFramework.GizmoElementLineRenderStateAttributes");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGizmoElementLineRenderStateAttributes() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGizmoElementLineRenderStateAttributes() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGizmoElementLineRenderStateAttributes A, FGizmoElementLineRenderStateAttributes B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGizmoElementLineRenderStateAttributes A, FGizmoElementLineRenderStateAttributes B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGizmoElementLineRenderStateAttributes;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGizmoElementColorAttribute LineColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LineColor, __ReturnBuffer);

					return *(FGizmoElementColorAttribute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LineColor, __InBuffer);
				}
			}
		}

		public FGizmoElementColorAttribute HoverLineColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HoverLineColor, __ReturnBuffer);

					return *(FGizmoElementColorAttribute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HoverLineColor, __InBuffer);
				}
			}
		}

		public FGizmoElementColorAttribute InteractLineColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InteractLineColor, __ReturnBuffer);

					return *(FGizmoElementColorAttribute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InteractLineColor, __InBuffer);
				}
			}
		}

		private static uint __LineColor = 0;

		private static uint __HoverLineColor = 0;

		private static uint __InteractLineColor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}