using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoElementMaterialAttribute")]
	public partial class FGizmoElementMaterialAttribute : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InteractiveToolsFramework.GizmoElementMaterialAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGizmoElementMaterialAttribute() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGizmoElementMaterialAttribute() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGizmoElementMaterialAttribute A, FGizmoElementMaterialAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGizmoElementMaterialAttribute A, FGizmoElementMaterialAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGizmoElementMaterialAttribute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<UMaterialInterface> Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(TWeakObjectPtr<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		public bool bOverridesChildState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverridesChildState, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverridesChildState, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		private static uint __bOverridesChildState = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}