using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.ActiveGizmo")]
	public partial class FActiveGizmo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InteractiveToolsFramework.ActiveGizmo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActiveGizmo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActiveGizmo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActiveGizmo A, FActiveGizmo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActiveGizmo A, FActiveGizmo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActiveGizmo;

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